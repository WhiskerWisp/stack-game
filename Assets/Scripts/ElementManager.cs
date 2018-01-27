using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour {

    public List<int> elements;
    public GameObject elementPrefab;
    public float gapSize;

    private List<GameObject> instantiatedElements = new List<GameObject>{};
    private int stackPointer;
    
    // Use this for initialization
    void Start () {
        stackPointer = elements.Count;
        for (int i = 0; i < elements.Count; i++) {
            GameObject instantiatedPrefab = Instantiate(elementPrefab,
                                                        transform.position + (new Vector3(0, i * gapSize, 0)),
                                                        Quaternion.identity);
            instantiatedPrefab.GetComponent<Element>().SetColour(elements[i]);
            instantiatedElements.Add(instantiatedPrefab);
        }
    }
	
    // Update is called once per frame
    void Update () {
        
    }

    public int RequestColour() {
        if (stackPointer < 0) {
            return 0;
        }
        instantiatedElements[stackPointer].Deactivate();
        stackPointer--;
        return elements[stackPointer + 1];
    }
}

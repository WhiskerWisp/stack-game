using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfManager : MonoBehaviour {

    public List<int> elements;
    public GameObject elementPrefab;
    public float gapSize;

    private List<GameObject> instantiatedElements = new List<GameObject>{};
    private int stackPointer;
    
    // Use this for initialization
    void Start () {
        // Find StartGame object and set settings
        elements = GameObject.FindWithTag("Start").GetComponent<StartGame>().shelf;
        
        stackPointer = elements.Count - 1;
        for (int i = 0; i < elements.Count; i++) {
            GameObject instantiatedPrefab =
                Instantiate(elementPrefab,
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
        instantiatedElements[stackPointer].GetComponent<Element>().Deactivate();
        // Reducing pointer and then incrementing by one. Trying to avoid variable declaration.
        stackPointer--;
        return elements[stackPointer + 1];
    }

    public void Restart() {
        for (int i = 0; i < elements.Count; i++) {
            instantiatedElements[i].GetComponent<Element>().Activate();
        }
        stackPointer = elements.Count - 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeManager : MonoBehaviour {

    public GameObject input;
    public GameObject output;
    public GameObject elementPrefab;
    public float gapSize;

    private List<GameObject> elements;
    private int stackPointer;
    
    // Use this for initialization
    void Start () {
        elements = new List<GameObject>{};
        stackPointer = elements.Count - 1;
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    // Called when corresponding PushButton is pressed.
    public void Push() {
        int colour = input.GetComponent<ElementManager>().RequestColour();
        if (colour < 1) {
            // Input has no more elements.
            return;
        }
        GameObject element =
            Instantiate(Instantiate(elementPrefab,
                                    transform.position + (new Vector3(0, stackPointer * gapSize, 0)),
                                    Quaternion.identity));
        element.GetComponent<Element>().SetColour(colour);
        elements.Add(element);
        stackPointer++;
    }

    // Called when corresponding PopButton is pressed.
    public void Pop() {
        
    }
  
}

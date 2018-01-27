using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcoctionManager : MonoBehaviour {

    public GameObject elementPrefab;
    public float gapSize;

    private List<GameObject> elements;
    
    // Use this for initialization
    void Start () {
        elements = new List<GameObject>{};
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public void GiveColour(int colour) {
        if (colour < 1) {
            return;
        }
        GameObject element =
            Instantiate(elementPrefab,
                                    transform.position + (new Vector3(0, elements.Count * gapSize, -1)),
                                    Quaternion.identity);
        element.GetComponent<Element>().SetColour(colour);
        elements.Add(element);
    }
}

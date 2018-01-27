using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcoctionManager : MonoBehaviour {

    public GameObject elementPrefab;
    public float startXPos;
    public float startYPos;
    public float gapSize;
    public List<int> expected;

    private List<GameObject> elements;
    
    // Use this for initialization
    void Start () {
        // Find StartGame object and set expected.
        expected = GameObject.FindWithTag("Start").GetComponent<StartGame>().expected;
        Destroy(GameObject.FindWithTag("Start"));
        
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
                        transform.position + (new Vector3(startXPos, startYPos + (elements.Count * gapSize), -1-(elements.Count * gapSize))),
                        Quaternion.identity);
        element.transform.parent = gameObject.transform;
        element.GetComponent<Element>().SetColour(colour);
        elements.Add(element);
        CheckWinCondition();
    }

    private void CheckWinCondition() {
        if (elements.Count != expected.Count) {
            return;
        }
        for (int i = 0; i < expected.Count; i++) {
            if (expected[i] != elements[i].GetComponent<Element>().GetColour()) {
                return;
            }
        }
        // Game is won!
        Debug.Log("You won!");
    }

    public void Restart() {
        while (elements.Count > 0) {
            Destroy(elements[elements.Count - 1]);
            elements.RemoveAt(elements.Count - 1);
        }
    }
}

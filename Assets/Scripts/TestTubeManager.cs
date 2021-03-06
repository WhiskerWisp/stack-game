﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeManager : MonoBehaviour {

    public GameObject input;
    public GameObject output;
    public GameObject elementPrefab;
    public float startYPos;
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
        int colour = input.GetComponent<ShelfManager>().RequestColour();
        if (colour < 1) {
            // Input has no more elements.
            return;
        }
        GameObject element =
            Instantiate(elementPrefab,
                                    transform.position + new Vector3(0, startYPos + ((stackPointer + 1) * gapSize), -1-((stackPointer + 1) * gapSize)),
                                    Quaternion.identity);
        element.transform.parent = gameObject.transform;
        element.GetComponent<Fill>().SetColour(colour);
        elements.Add(element);
        stackPointer++;
    }

    // Called when corresponding PopButton is pressed.
    public void Pop() {
        output.GetComponent<ConcoctionManager>().GiveColour(RequestColour());
    }

    public int RequestColour() {
        if (stackPointer < 0) {
            return 0;
        }
        int colour = elements[stackPointer].GetComponent<Fill>().GetColour();
        Destroy(elements[stackPointer]);
        elements.RemoveAt(stackPointer);
        stackPointer--;
        return colour;
    }

    public void Restart() {
        while (stackPointer >= 0) {
            RequestColour();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeManager : MonoBehaviour {

    public GameObject input;
    public GameObject output;
    
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    // Called when corresponding PushButton is pressed.
    public void Push() {
        int colour = input.GetComponent<ElementManager>().RequestColour();
    }

    // Called when corresponding PopButton is pressed.
    public void Pop() {
        
    }
  
}

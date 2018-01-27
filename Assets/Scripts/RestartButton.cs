using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {

    public List<GameObject> testtubes;
    public GameObject shelf;
    public GameObject concoction;
    
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    void OnMouseDown() {
        concoction.GetComponent<ConcoctionManager>().Restart();
        shelf.GetComponent<ShelfManager>().Restart();
        for (int i = 0; i < testtubes.Count; i++) {
            testtubes[i].GetComponent<TestTubeManager>().Restart();
        }
    }
}

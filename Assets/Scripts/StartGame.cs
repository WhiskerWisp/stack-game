using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public List<int> shelf;
    public List<int> expected;

    // Use this for initialization
    void Start () {
      
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    void OnMouseDown() {
        DontDestroyOnLoad(gameObject);
        Application.LoadLevel("MainGame");
    }
    
}

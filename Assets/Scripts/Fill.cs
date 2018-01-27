using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill : MonoBehaviour {

    private int colour;
    public Sprite[] fills;
    
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public void SetColour(int col) {
        colour = col;
        gameObject.GetComponent<SpriteRenderer>().sprite = fills[col-1];
    }

    public int GetColour() {
        return colour;
    }

    public void Activate() {
        gameObject.SetActive(true);
    }
    
    public void Deactivate() {
        gameObject.SetActive(false);
    }
}

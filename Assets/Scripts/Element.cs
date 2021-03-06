﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour {

    private int colour;
    public Sprite[] potions;
    
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public void SetColour(int col) {
        colour = col;
        transform.Find("Fill").gameObject.GetComponent<SpriteRenderer>().sprite = potions[col-1];
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

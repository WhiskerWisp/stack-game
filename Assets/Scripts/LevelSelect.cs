﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    // Use this for initialization
    void Start () {
      
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public void LoadLevelSelectScreen() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }
    
}

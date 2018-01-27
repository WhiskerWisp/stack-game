using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectAfterTime : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		 yield return new WaitForSeconds(1);
     UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

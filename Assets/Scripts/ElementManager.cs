using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour {

  public int[] elements;
  public GameObject elementPrefab;
  
	// Use this for initialization
	void Start () {
		for (int i = 0; i < elements.Length; i++) {
      //print(elements[i]);
      Instantiate(elementPrefab,
                  transform.position + (new Vector3(0, i * 0.5f, 0)),
                  Quaternion.identity);
    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

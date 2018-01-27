using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour {

  public int[] elements;
  public GameObject elementPrefab;
  public float gapSize;
  
	// Use this for initialization
	void Start () {
		for (int i = 0; i < elements.Length; i++) {
      //print(elements[i]);
      Instantiate(elementPrefab,
                  transform.position + (new Vector3(0, i * gapSize, 0)),
                  Quaternion.identity);
    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

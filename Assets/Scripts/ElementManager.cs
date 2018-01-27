using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour {

  public List<int> elements;
  private List<int> instantiatedElements;
  public GameObject elementPrefab;
  public float gapSize;
  
	// Use this for initialization
	void Start () {
		for (int i = 0; i < elements.Count; i++) {
      Instantiate(elementPrefab,
                  transform.position + (new Vector3(0, i * gapSize, 0)),
                  Quaternion.identity);
    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

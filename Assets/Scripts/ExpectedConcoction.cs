using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpectedConcoction : MonoBehaviour {

	public GameObject concoction;
	public GameObject elementPrefab;
	public Sprite[] fills;
	public float startXPos;
	public float startYPos;
	public float gapSize;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(0.2f);
		concoction = GameObject.Find("Concoction");
		for (int i=0; i < concoction.GetComponent<ConcoctionManager>().expected.Count; i++) {
			GameObject element =
            Instantiate(elementPrefab,
                        transform.position + (new Vector3(startXPos, startYPos + (i * gapSize), -1-(i * gapSize))),
                        Quaternion.identity);
        element.transform.parent = gameObject.transform;
        element.transform.localScale = new Vector3(41f, 41f, 41f);
			  element.GetComponent<SpriteRenderer>().sprite = fills[concoction.GetComponent<ConcoctionManager>().expected[i]-1];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

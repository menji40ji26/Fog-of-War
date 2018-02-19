using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGen : MonoBehaviour {

	public GameObject c;
	public float w = 10;
	public float h = 10;
	public float s = 5;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < w; x++){
			for (int y = 0; y < h; y++){
				GameObject cClone = Instantiate(c, new Vector3(transform.position.x + x * s, transform.position.y, transform.position.z + y * s), Quaternion.identity);
				cClone.name = "Cloud_" + x + "_" + y;
				cClone.transform.SetParent(transform);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

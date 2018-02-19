using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 c = camera.position;
        if (Input.GetKey("w")){
			c = new Vector3 (c.x + 1, c.y, c.z);
		}
        if (Input.GetKey("s")){
			c = new Vector3 (c.x - 1, c.y, c.z);
		}
        if (Input.GetKey("a")){
			c = new Vector3 (c.x, c.y, c.z + 1);
		}
        if (Input.GetKey("d")){
			c = new Vector3 (c.x, c.y, c.z - 1);
		}
		camera.position = c;
	}


}

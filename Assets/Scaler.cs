﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

	public float speed = 5;
	public float maxSize = 5f;
	bool desiredState;
	bool doScaling = false;

	// Update is called once per frame
	void Update () {
		if(doScaling){
			if(!desiredState){
				Vector3 desiredSize = new Vector3(transform.localScale.x - Time.deltaTime * speed, transform.localScale.y - Time.deltaTime * speed, transform.localScale.z - Time.deltaTime * speed);
				transform.localScale = desiredSize;

				if(transform.localScale.x <= 0.1){
					gameObject.SetActive(false);
					doScaling = false;
				}
			} else if(desiredState){
				Vector3 desiredSize = new Vector3(transform.localScale.x + Time.deltaTime * speed, transform.localScale.y + Time.deltaTime * speed, transform.localScale.z + Time.deltaTime * speed);
				transform.localScale = desiredSize;

				if(transform.localScale.x >= maxSize){
					transform.localScale = new Vector3(maxSize, maxSize, maxSize);
					gameObject.SetActive(true);
					doScaling = false;
				}
			}
		}
	}

	public void ToggleScale(bool setType){
		desiredState = setType;
		doScaling = true;
	}
}

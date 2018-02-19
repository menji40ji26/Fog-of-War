using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHider : MonoBehaviour {

	public GameObject mapObj;
	public float desiredDistance = 8;
	public float maxDistance = 100;
	public bool doShow = true;
	public bool doScale = false;
	
	// Update is called once per frame
	void Update () {
		disapearCheck();
	}

	private void disapearCheck(){
		for (int i = 0; i < mapObj.transform.childCount; i++){		
			Transform c = mapObj.transform.GetChild(i);	
			float distance = Vector3.Distance(c.position, transform.position);

			if(distance < desiredDistance){
				if(!doShow){
					if(!c.gameObject.activeInHierarchy){
						c.gameObject.SetActive(true);
					}
				} else {
					if(c.gameObject.activeInHierarchy && !doScale){
						c.gameObject.SetActive(false);
					} else if(c.gameObject.activeInHierarchy && doScale){
						c.GetComponent<Scaler>().ToggleScale(false);
					}
				}
			} else {
				if(!doShow){
					if(c.gameObject.activeInHierarchy){
						c.gameObject.SetActive(false);
					}
				} else {
					if(distance < maxDistance) {
						if(!c.gameObject.activeInHierarchy && !doScale){
							c.gameObject.SetActive(true);
						} else if (!c.gameObject.activeInHierarchy && doScale){
							c.gameObject.SetActive(true);
							c.GetComponent<Scaler>().ToggleScale(true);
						}
					} else {
						c.gameObject.SetActive(false);
					}
				}
			}

			
			
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrole : MonoBehaviour {
	private float a;
	private float min;
	private float max;
	// Use this for initialization
	void Start () {
		max = 11.5f;
		min = -11.5f;
		a = 0.0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(Time.timeScale==1){
		if (record.recp != null) {
				if (gameObject.transform.position.y > min) {
					a = gameObject.transform.position.y;
					a -= 0.05f;
					gameObject.transform.position = new Vector3 (gameObject.transform.position.x, a, gameObject.transform.position.z);
				} else {
					gameObject.transform.position = new Vector3 (gameObject.transform.position.x, max, gameObject.transform.position.z);
				}
			}
	
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class debug : MonoBehaviour {
	public GameObject i;
	public InputField f;
	public GameObject o;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		f = o.GetComponent<InputField> ();
		i.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			if (i.activeSelf == false) {
				i.SetActive (true);
			} else {
				i.SetActive (false);
			}
		}
		if (SceneManager.GetActiveScene ().name == "Shoot") {
			if (PlayerGame.life <= 0) {
				
					Cursor.visible = true;
				} else {
				
					Cursor.visible = false;

				}
					

		}
	
	}
}

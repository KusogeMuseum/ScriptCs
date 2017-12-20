using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Replay : MonoBehaviour {
    private GameObject ob;
	private int i;
	private GameObject rep;
	static public List <float> tim; 
	static public List <Vector3> ve1;
	static public List <Vector3> ve2;
	private float time;
	static private int count;
	public GameObject bullet;
	private GameObject bulletI;
	public GameObject exprotion;
    private float ReTime;
	static private float time1;
	static private int exI;
	static private int exIs;
	public GameObject ene;

	private Gamemanage m;
	static private int T;
	static private float tims;
	private SpriteRenderer re;
	// Use this for initialzation
	void Start () {
		tims = 0;
		i = 0;
		exI = 0;
		exIs = 0;
		time1 = 0.0f;
		count = 0;

		T = 0;

		ob = GameObject.FindGameObjectWithTag ("Player");
		foreach (Transform tr in ob.transform) {
			bulletI = tr.gameObject;
		}
		rep = GameObject.FindGameObjectWithTag ("REPG");
		re = ob.GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "menu") {
			ReplayP ();
			ReplayE ();
		}


	}
	void ReplayP(){
		

		time += Time.deltaTime;
		if (record.recp != null) {
			if (i < record.recp.Count) {
					if (Playercontorol.movetime.Count > T) {
						
						
							ob.transform.position = record.recp [i];
							
							i += 1;



					if (count < Playercontorol.pushtime.Count) {
						if (Playercontorol.pushtime [count] > time && Playercontorol.pushtime [count] - 0.1f < time) {
							Instantiate (bullet, bulletI.transform.position, Quaternion.identity);
							count += 1;
						}

					
					}
				}
			

			} else {
				if (i == record.recp.Count) {
					m = rep.GetComponent<Gamemanage> ();
					m.enabled = false;
					ReTime += Time.deltaTime;
					Vector3 tra = ob.transform.position;
					SpriteRenderer re = ob.GetComponent<SpriteRenderer> ();
					re.enabled = false;
					if (PlayerGame.g == false) {
						GameObject O = Instantiate (exprotion, tra, Quaternion.identity);
					
						if (ReTime >= 2.0f) {
							Destroy (O);
						}
					}
					if (ReTime >= 3.0f) {
						i = 0;
						count = 0;
						ReTime = 0.0f;
						time = 0.0f;
						re.enabled = true;
						m.enabled = true;

						exI = 0;
						exIs = 0;
						time1 = 0.0f;
						T = 0;
						Gamemanage.time = 0;
				
					}
				}
			}
		
				
		} else {
			if (rep != null) {
				rep.SetActive (false);
			}
		}
	}
				
			
				
	void ReplayE (){
		

		time1 += Time.deltaTime;
			if (EnemyIns.insvec != null && EnemyIns.Eurer != null) {
				if (EnemyIns.insvec.Count > exI || EnemyIns.Eurer.Count > exIs) {
				
				if (time1 >= 0.4f) {
					
					Instantiate (ene, EnemyIns.insvec [exI], Quaternion.Euler (EnemyIns.Eurer [exIs]));
					exI += 1;
					exIs += 1;
					time1 = 0.0f;
				}
			}

		}
	
	}
}
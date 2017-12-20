using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyIns : MonoBehaviour {
    public GameObject enemy;
    private float time;
    private Vector3 WH;
    private Vector3 Wh2;
    private GameObject player;
    private float Ctime;
    private Effect e;
    public GameObject camera1;
	static public List<Vector3> insvec;
	static public List<Vector3> Eurer;
	static public List<float> InsTime;
	private float PlayTime;
	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene ().name == "Shoot") {
			insvec = new List<Vector3> ();
			Eurer = new List<Vector3> ();
			InsTime = new List<float> ();
			PlayTime = 0;
			time = 0;
			Ctime = 0;
		}
       WH=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height/2,0));
        Wh2 = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        player = GameObject.FindGameObjectWithTag("Player");
        e = camera1.GetComponent<Effect>();

	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            Ctime += Time.deltaTime;
			PlayTime += Time.deltaTime;
            if (Ctime <= 170.0f)
            {

            time += Time.deltaTime;
            if (time >=0.4f)
            {
                int R = Random.Range(0, 3);
                switch (R)
                {
					case 0:

						float Hr = Random.Range (WH.y, Wh2.y);
						insvec.Add (new Vector2 (-WH.x, Hr));
						Eurer.Add (new Vector3 (0, 0, -90));
						Instantiate (enemy, new Vector2 (-WH.x, Hr), Quaternion.Euler (0, 0, -90));
						time = 0;
						InsTime.Add (PlayTime);
                        break;
                    case 1:

                        float Hr1 = Random.Range(WH.y, Wh2.y);
						insvec.Add (new Vector2 (WH.x, Hr1));
						Eurer.Add(new Vector3(0, 0, 90));
                        Instantiate(enemy, new Vector2(WH.x, Hr1), Quaternion.Euler(0, 0, 90));
                        time = 0;
						InsTime.Add (PlayTime);
                        break;
					case 2:

						float Hr2 = Random.Range (-WH.x, WH.x);
						insvec.Add (new Vector2 (Hr2, Wh2.y));
						Eurer.Add(new Vector3(0, 0, -180));
                        Instantiate(enemy, new Vector2(Hr2, Wh2.y), Quaternion.Euler(0, 0, -180));
                        time = 0;
						InsTime.Add (PlayTime);
                        break;


                }
            }


            }
            else
            {
                e.RGBNoise += 0.01f;
                if (e.RGBNoise >= 1)
                {
                    e.RGBNoise = 1;
                    SceneManager.LoadScene("menu");
                }
            }
        }
        else
        {
            this.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontorol : MonoBehaviour {
    private Vector3 Mpos;
    private Vector3 Wpos;
    public GameObject Inspos;
    public GameObject bullets;
    private Vector2 cam;
    private AudioSource audioSource;
	static public List<float> pushtime;
	static public List<float> movetime;
	private float timeP;
	void Start () {
		pushtime = new List<float> ();
		movetime = new List<float> ();
        audioSource = gameObject.GetComponent<AudioSource>();
        cam = new Vector2(Screen.width, Screen.height);
        Debug.LogWarning(cam);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeP += Time.deltaTime;
        if(Input.GetMouseButton(0))
        {
			pushtime.Add (timeP);
            audioSource.PlayOneShot(audioSource.clip);
                Instantiate(bullets, Inspos.transform.position, Quaternion.identity);
               

        }
        
        Mpos = Input.mousePosition;
        if (Mpos.y <= 0)
        {
            Mpos.y = 0;
        }
        if (Mpos.y >= cam.y)
        {
            Mpos.y = cam.y;
        }
        if (Mpos.x <= 0)
        {
            Mpos.x = 0;
        }
        if (Mpos.x >= cam.x)
        {
            Mpos.x = cam.x;
        }
        Wpos = Camera.main.ScreenToWorldPoint(Mpos);
        Wpos.z = 0;

        gameObject.transform.position = Wpos;
		movetime.Add (timeP);
        
        
    }
}

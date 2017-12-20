using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGame : MonoBehaviour {
    static public int life;
    public GameObject ex;
    private AudioSource s;
    public GameObject over;
    private SpriteRenderer re;
    private bool B;
    private float f;
    private float t;
    public GameObject ob;
	static public bool g;
	// Use this for initialization
	void Start () {
        AudioSource[] audio = gameObject.GetComponents<AudioSource>();
        B = false;
        re = gameObject.GetComponent<SpriteRenderer>();
        s = audio[1];
        life = 100;
		g = true;
	}
	
	// Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 0.1f)
        {
            B = false;
            t = 0;
            }

        if (B == true)
        {
            f +=0.1f;
            if (f <= 0.01f)
            {
                re.enabled = false;
            }
            else
            {
                f = 0.0f;
                re.enabled = true;
            }
        }
        if (life <= 0)
        {
            Dest();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            life = 0;
        }
        if (collision.gameObject.tag == "MI")
        {
            B = true;
            
            life -= 10;
        }
        
    }


   
    void Dest()
    {
        if (Score.Hb)
        {
			ob.SetActive(true);
        }
        else
        {
            over.SetActive(true);
        }
		g = false;
        Vector2 pos = transform.position;
        s.PlayOneShot(s.clip);
        Destroy(gameObject);
        Instantiate(ex, pos, Quaternion.identity);
    }
}

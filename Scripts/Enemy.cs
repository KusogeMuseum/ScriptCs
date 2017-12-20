using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int life;
    public GameObject Ex;
    public GameObject tr;
    public GameObject miss;
    private AudioSource s;
    private GameObject score;
    static public float speed;
    private Score sc;
	// Use this for initialization
	void Start () {
        score = GameObject.FindGameObjectWithTag("Score");
        sc = score.GetComponent<Score>();
        Instantiate(miss, tr.gameObject.transform.position, Quaternion.Euler(transform.eulerAngles));
        AudioSource[] audio = gameObject.GetComponents<AudioSource>();
        s = audio[1];
	}
	
	// Update is called once per frame
	void Update () {
        if (life <= 0)
        {
            sc.Scre += 10;
            de();
        }
        transform.position +=transform.up*speed;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.tag == "bullet")
        {
            life -= life;
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void de()
    {
       
        Vector2 pos = transform.position;
        s.PlayOneShot(s.clip);
        Instantiate(Ex, pos, Quaternion.identity);
        Destroy(gameObject);
        
    }
}

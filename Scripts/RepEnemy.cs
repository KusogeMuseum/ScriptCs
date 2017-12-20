using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepEnemy : MonoBehaviour {

	public int life;
	public GameObject Ex;
	public GameObject tr;
	public GameObject miss;
	static public float speed;
	private Score sc;
	// Use this for initialization
	void Start () {
		Instantiate(miss, tr.gameObject.transform.position, Quaternion.Euler(transform.eulerAngles));

	}

	// Update is called once per frame
	void Update () {
		if (life <= 0)
		{
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
		Instantiate(Ex, pos, Quaternion.identity);
		Destroy(gameObject);

	}
}

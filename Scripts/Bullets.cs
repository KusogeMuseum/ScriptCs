using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private float desT;
    public GameObject Ex;
    private float dest2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        desT += Time.deltaTime;
        transform.position += transform.up * 1f;
        if (desT >= 0.15f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
          

            Destroy(gameObject);
        }
    }
}

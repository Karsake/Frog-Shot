using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceShard : MonoBehaviour
{

    public float Icespeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(1, 0);
		rb.AddForce(movement * Icespeed);
    }
    void OnTriggerEnter2D(Collider2D other)
    {


		if (other.gameObject.CompareTag("Boss")||other.gameObject.CompareTag("Wall"))
			{
				Destroy(gameObject);
			}

    }
}
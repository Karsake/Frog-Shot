using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float Bulletspeed;
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate()
	{
		Vector2 movement = new Vector2(-1, 0);
		rb.AddForce(movement * Bulletspeed);
	}
	void OnTriggerEnter2D(Collider2D other)
	{


		if (other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("Wall"))
		{
			Destroy(gameObject);
		}

	}
}
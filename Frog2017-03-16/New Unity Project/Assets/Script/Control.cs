using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public float speed,Firerate,i;
	public float fireDelta = 0.1F;
	private float nextFire = 0.1F;
	private float myTime = 0.0F;
	Animator animator;

	public GameObject IceShard;
	public Transform IceSpwan;

	private Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>(); 
		animator = GetComponent<Animator> ();
	}

	void Update()
	{
		myTime = myTime + Time.deltaTime;
		if (Input.GetButton ("Fire1") && myTime > nextFire)
		{
			nextFire = myTime + fireDelta;
			Instantiate (IceShard, IceSpwan.position, IceSpwan.rotation);
			nextFire = nextFire - myTime;
			myTime = 0.0F;
			animator.SetTrigger ("attack");
		}
		if (Input.GetButton ("Fire1")) {
		
		}
		else animator.SetTrigger ("back");

		if (Input.GetButton ("Jump")) 
		{
			animator.SetBool ("dead", false);
			i = 1;
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Bullet"))
		{
			animator.SetBool ("dead",true);
			rb2d.AddForce(new Vector2(0,-1));
			i = -1;
		}

	}

	void FixedUpdate()
	{
		float ud = Input.GetAxisRaw("Vertical");
		Vector2 movement = new Vector2(0,ud);
		if(i==1)
		rb2d.AddForce(movement * speed);
		if(i==-1)
			rb2d.AddForce(new Vector2(0,-20));
	}
}

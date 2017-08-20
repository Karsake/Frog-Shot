using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

	public GameObject Bullet;
	public Transform BulletSpwan1,BulletSpwan2;
	public int i;
	public float Firerate;
	public float fireDelta = 2F;
	private float nextFire = 2F;
	private float myTime = 0.0F;
	void Update ()
	{
		myTime = myTime + Time.deltaTime;
		if (myTime > nextFire) {
			nextFire = myTime + fireDelta;
			if (i == 1) {
				Instantiate (Bullet, BulletSpwan1.position, BulletSpwan1.rotation);
				i = 2;
			} else {
				Instantiate (Bullet, BulletSpwan2.position, BulletSpwan2.rotation);
				i = 1;
			}
			nextFire = nextFire - myTime;
			myTime = 0.0F;
		}
	}
}
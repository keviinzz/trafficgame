﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleScript : MonoBehaviour {

	[SerializeField]
	private Sprite[] arraySprite;
	[SerializeField]
	private Transform rayFront;
	[SerializeField]
	private Transform rayStart;
	private Rigidbody2D rb;
	private RaycastHit2D hit;
	private bool frontEmpty = true;
	private SpriteRenderer sprite;
	private int speed=2;
	private AudioSource carcrash; 
	public score s;
    public ingameUIScript iuis;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer>();
		sprite.sprite = arraySprite[Random.Range(0, arraySprite.Length)];
		rb = GetComponent<Rigidbody2D>();
		carcrash = GetComponent<AudioSource>();

	}

	// Update changed to FixedUpdate because why not
	void FixedUpdate () {

		checkFront();

		rb.AddForce(transform.right * speed);

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		speed = 0;
		soundOn();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "roadStop")
		{

			speed = 0;
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawLine(rayStart.position, rayFront.transform.position);
	}

	void checkFront()
	{
		hit = Physics2D.Linecast(rayStart.position, rayFront.position);
		if (hit.collider!=null)
		{
			if(hit.collider.tag=="Car")
			{
				speed = 0;
			}
			if (hit.collider.tag == "Despawn"){
				s.addScore();
                iuis.addHappiness();
				Destroy (gameObject);
				//gamemanager.GetComponent<score> ().addScore ();
			}
            if (hit.collider.tag == "DespawnNoScore")
            {
                Destroy(gameObject);
                //gamemanager.GetComponent<score> ().addScore ();

            }

        }


	}


	public void setSpeed(int v)
	{
		speed = v;
	}

	public void soundOn()
	{
		carcrash.Play();
	}
}

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
	private int speed=4;
	private AudioSource carcrash; 
	public score s;
    public ingameUIScript iuis;
    private float defaultdrag = 2.5f;

    // Use this for initialization
    void Start() {
        int spriteNumber = Random.Range(0, arraySprite.Length);
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = arraySprite[spriteNumber];
        if (spriteNumber >= 1) {
            sprite.material.color = new Color(Random.Range(0.2f, 1f), Random.Range(0.2f, 1f), Random.Range(0.2f, 1f), 1f);
     }
        rb = GetComponent<Rigidbody2D>();
		carcrash = GetComponent<AudioSource>();

	}

	// Update changed to FixedUpdate because why not
	void FixedUpdate () {

		checkFront();

		rb.AddForce(transform.up * speed);

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
                brake();
				
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
        else
        {
            rb.drag = defaultdrag;
        }


	}

    public void brake()
    {
        speed = 0;
        rb.drag = 5;
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

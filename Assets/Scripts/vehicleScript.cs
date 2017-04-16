using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleScript : MonoBehaviour {

    [SerializeField]
    private Sprite[] arraySprite;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    int speed=1;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = arraySprite[Random.Range(0, arraySprite.Length)];
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        rb.AddForce(transform.right * speed);

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "roadStop")
        {

            speed = 0;
        }
    }
}

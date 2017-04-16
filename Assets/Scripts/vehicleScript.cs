using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleScript : MonoBehaviour {

    [SerializeField]
    private Sprite[] arraySprite;
    [SerializeField]
    private Transform rayFront;
    private Rigidbody2D rb;
    private RaycastHit2D hit;
    private bool frontEmpty = true;
    private SpriteRenderer sprite;
    private int speed=1;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = arraySprite[Random.Range(0, arraySprite.Length)];
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        checkFront();

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

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(this.transform.position, rayFront.transform.position);
    }

    void checkFront()
    {
        hit = Physics2D.Linecast(this.transform.position, rayFront.position);
        if (hit.collider!=null)
        {
            if(hit.collider.tag=="Car")
            speed = 0;
        }
     
    }
}

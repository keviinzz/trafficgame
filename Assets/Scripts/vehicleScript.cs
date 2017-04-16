using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleScript : MonoBehaviour {

    Rigidbody2D rb;
    int speed=1;
	// Use this for initialization
	void Start () {
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
}

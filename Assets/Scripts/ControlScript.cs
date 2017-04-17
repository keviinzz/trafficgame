using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

    RaycastHit hit;
    Ray ray;
    // Use this for initialization
    void Start () {
         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            ClickSelect();
        }
	}

    GameObject ClickSelect()
    {
       
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
            Debug.Log(hit.transform.name);
           

            if (hit.transform.tag == "Car")
            {
                hit.transform.GetComponent<VehicleScript>().setSpeed(2);
            }
            return hit.transform.gameObject;
        }
        else return null;
    }
}

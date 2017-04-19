using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {
    //asdsda
    [SerializeField]
    private GameObject police;
    [SerializeField]
    private GameObject police2;
    RaycastHit hit;
    Ray ray;
    [SerializeField]
    private AudioSource whistle;

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
                whistle.Play();
                if(hit.transform.position.x>0)
                    police.transform.up = hit.transform.position - police.transform.position;

                if(hit.transform.position.x<0)
                    police2.transform.up = hit.transform.position - police2.transform.position;
                hit.transform.GetComponent<vehicleScript>().setSpeed(4);
            }
            return hit.transform.gameObject;
        }
        else return null;
    }
}

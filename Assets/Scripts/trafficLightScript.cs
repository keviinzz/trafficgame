using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficLightScript : MonoBehaviour {

    
    enum Light { Red, Green};
     Light currentLight;
    SpriteRenderer renderer;
    Collider2D collider;

    // Use this for initialization
    void Start () {
        collider = GetComponent<Collider2D>();
        currentLight = Light.Red;
      //  renderer = GetComponent<SpriteRenderer>();
      //  renderer.color = new Color(255, 0, 0,30);
    }
	
	// Update is called once per frame
	void Update () {
        if (currentLight == Light.Green)
        {
            collider.enabled = false;
          //  renderer.color = new Color(0,255,0,30);
        }
        else
        {
           
         //   renderer.color = new Color(255, 0, 0,30);
        }

	}
}

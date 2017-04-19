using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour {


    
    int i = 1;
    [SerializeField]
    private GameObject car;

    private bool cool = false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
            if (!cool)
            {
                if (i == Random.Range(1, 300))
                {
                    cool = true;
                    Instantiate(car, transform.position, transform.rotation);
                    StartCoroutine(cooldown(Random.Range(2, 5)));
                    i = Random.Range(1, 200);
                }
            }
        
    }

    IEnumerator cooldown(float wait)
    {

       // print("cool");
        yield return new WaitForSeconds(wait);
        cool = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueScript : MonoBehaviour
{


    private int maxQueue = 5;
    // private int queue = 0;
    int i = 1;
    [SerializeField]
    private GameObject car;
    private bool cool = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount < maxQueue)
        {
            if (!cool)
            {
                if (i == Random.Range(1, 400))
                {
                    cool = true;
                    GameObject clone = Instantiate(car, transform.position, transform.rotation);
                    // queue++;
                    clone.transform.parent = gameObject.transform;
                    StartCoroutine(cooldown(Random.Range(2, 5)));
                    i = Random.Range(1, 200);
                }
            }
        }
    }

    IEnumerator cooldown(float wait)
    {

        //print("cool");
        yield return new WaitForSeconds(wait);
        cool = false;
    }
}

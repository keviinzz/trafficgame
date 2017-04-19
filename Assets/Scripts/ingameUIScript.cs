using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingameUIScript : MonoBehaviour {

	[SerializeField]
	private int totalHappiness;
	private int topHappiness=100;
	private int drainHappiness=2;
	private bool tick=true;
  
	//private int tickloop=5000;

	[SerializeField]
	private GameObject bar;
    private Image sr;
    
	// Use this for initialization
	void Start () {
		totalHappiness  = topHappiness;
        sr=bar.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (totalHappiness > topHappiness)
			totalHappiness = topHappiness;
		if (totalHappiness < 0)
			totalHappiness = 0;
	//	print (totalHappiness);

        if(tick)StartCoroutine (drainBar ());
		updateBar ();

        if (totalHappiness>70) {
            sr.color = Color.green;
        }
        else if (totalHappiness <= 70 && totalHappiness > 25)
        {
            sr.color = Color.yellow;
        }
        else
        {
            sr.color = Color.red;
        }
	}

    public void addHappiness()
    {
        totalHappiness = totalHappiness + 10;
    }

	IEnumerator drainBar(){
         tick = false;
		 totalHappiness = totalHappiness - drainHappiness;
		 yield return new WaitForSeconds (1f);
         tick = true;
	}

	void updateBar(){
		float currBar;
		currBar=(float)totalHappiness / topHappiness;
		bar.transform.localScale = new Vector3 (currBar, 1, 1);
	}
}

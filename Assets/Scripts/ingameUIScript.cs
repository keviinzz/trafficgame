using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingameUIScript : MonoBehaviour {

	[SerializeField]
	private int totalHappiness;
	private int topHappiness=5000;
	private int drainHappiness=1;
	private bool tick=true;
	private int tickloop=5000;

	[SerializeField]
	private GameObject bar;

	// Use this for initialization
	void Start () {
		totalHappiness  = topHappiness;
	}
	
	// Update is called once per frame
	void Update () {
		if (totalHappiness > topHappiness)
			totalHappiness = topHappiness;
		if (totalHappiness < 0)
			totalHappiness = 0;
		print (totalHappiness);

		StartCoroutine (drainBar ());
		updateBar ();
	}

	IEnumerator drainBar(){
		

			totalHappiness = totalHappiness - drainHappiness;
			yield return new WaitForSeconds (100f);

	}

	void updateBar(){
		float currBar;
		currBar=(float)totalHappiness / topHappiness;
		bar.transform.localScale = new Vector3 (currBar, 1, 1);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

	public GameObject medal;
	public GameObject red_medal;

	public int[] feed_medals = new int[] {300, 300};
	private float[] feed_time = new float[2];
	public GameObject[] medal_feeder = new GameObject[2];

	private GameObject take_medal()
	{
		if (Random.value < 0.05f) {
			return (red_medal);
		} else {
			return (medal);
		}
	}

	// Use this for initialization
	void Start () {
		//for (int cnt = 0; cnt < first_medals; cnt++) {
		//	Instantiate (take_medal(), new Vector3 (-3 + Random.value * 6, 0.3f, -5 + Random.value * 5), transform.rotation);
		//}
		feed_time[0] = 0;
		feed_time [1] = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		for (int feed_idx = 0; feed_idx < 2; feed_idx ++) {
			feed_time[feed_idx] += Time.deltaTime;
			if (feed_medals [feed_idx] > 0 && feed_time [feed_idx] > 0.1f) {
				float force = Random.value * 5f + 5f;
				var obj = Instantiate (take_medal (), medal_feeder [feed_idx].transform.position, medal_feeder [feed_idx].transform.rotation);
				obj.GetComponent<Rigidbody> ().AddForce (medal_feeder [feed_idx].transform.forward * force, ForceMode.Impulse);
				feed_medals [feed_idx]--;
				feed_time [feed_idx] = 0;
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			//float x = -2.0f + Random.value * 4.0f;
			//Instantiate(take_medal (), new Vector3 (x, 1, 0), Random.rotation);
			feed_medals[0] ++;
		}
	}
}

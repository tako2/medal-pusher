using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleCheckScript : MonoBehaviour {

	public float check_dist = 0.15f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		var diff = Vector3.Distance (other.transform.position, transform.position);
		print("diff: " + diff.ToString());
		if (diff < check_dist) {
			Destroy (other.gameObject);
		}
	}

	void OnTriggerStay(Collider other)
	{
		var diff = Vector3.Distance (other.transform.position, transform.position);
		print("diff: " + diff.ToString());
		if (diff < check_dist) {
			Destroy (other.gameObject);
		}
	}
}

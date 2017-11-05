using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherControlScript : MonoBehaviour {

	public float amp;

	private Rigidbody rb;
	private Vector3 init_position;

	// Use this for initialization
	void Start () {
		rb = transform.GetComponent<Rigidbody> ();
		init_position = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 new_position = new Vector3 (init_position.x, init_position.y,
			                       init_position.z + Mathf.Sin (Time.time) * amp);
		rb.MovePosition (new_position);
	}
}

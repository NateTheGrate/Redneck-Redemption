using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlller : MonoBehaviour {

	public float speed = 5.0f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Like update but used for physics calls
	void FixedUpdate () {

		// universal controls :)
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (horizontal, 0.0f, vertical);

		rb.AddForce (movement * speed * Time.deltaTime);
	}

	// Update is called once per frame
	void Update () {

	}
}

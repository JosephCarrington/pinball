using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactingPusherController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float solenoidForce = 20;
	void Fire() {
	}

	void OnTriggerEnter2D(Collider2D col) {
		col.gameObject.GetComponent<Rigidbody2D> ().AddForce (transform.up * solenoidForce, ForceMode2D.Impulse);
		transform.Find ("Pusher").GetComponent<Animator> ().SetTrigger ("Fire");
	}
}

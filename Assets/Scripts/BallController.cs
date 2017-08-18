using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	// Use this for initialization
	public bool inPlay = false;
	private Rigidbody2D body;
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetInPlay(bool play) {
		inPlay = play;
		body.isKinematic = !play;
		if (!play) {
			body.velocity = Vector2.zero;
		}
	}

	public void BoostBall(Vector2 boost) {
		body.AddForce (boost, ForceMode2D.Impulse);
	}
}

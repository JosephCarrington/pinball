using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour {

	public float launchForce = 30f;
	public float maxAngle = 45f;
	private bool isLaunching = true;
	private GameObject ball;
	BallController ballController;
	void Start () {
		ball = GameObject.Find ("Ball");
		ballController = ball.GetComponent<BallController> ();
	}

	void Update () {
		if (isLaunching) {
			if (Input.GetButtonDown ("Interact")) {

				ballController.SetInPlay (true);
				ballController.BoostBall (gameObject.transform.up * launchForce);
				isLaunching = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (!isLaunching && col.gameObject == ball) {
			ballController.SetInPlay (false);
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDisplayController : MonoBehaviour {

	// Use this for initialization
	public int startingBalls = 3;
	public GameObject ballIconPrefab;
	void Awake () {
		for (int i = 0; i < startingBalls; i++) {
			GameObject.Instantiate (ballIconPrefab, transform);
		}
	}
	
	public void RemoveBall() {
		Destroy (gameObject.transform.GetChild (0).gameObject);
	}

	public int BallCount() {
		return transform.childCount;
	}
}

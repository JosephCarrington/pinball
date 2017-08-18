using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterController : MonoBehaviour {

	// Use this for initialization
	public Color disabledColor;
	private Color startColor;
	public float disableTime = 1f;
	void Start () {
		startColor = gameObject.GetComponent<SpriteRenderer> ().color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Ball" || col.gameObject.tag == "Cheating Ball") {
			// Do the boost as normal
			gameObject.GetComponent<SpriteRenderer> ().color = disabledColor;
			gameObject.GetComponent<AreaEffector2D> ().enabled = false;
			StartCoroutine (ReEnable ());
		}
	}

	IEnumerator ReEnable() {
		yield return new WaitForSeconds(disableTime);
		gameObject.GetComponent<SpriteRenderer> ().color = startColor;
		gameObject.GetComponent<AreaEffector2D> ().enabled = true;
	}
}

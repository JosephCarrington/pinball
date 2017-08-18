using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterController : MonoBehaviour {

	// Use this for initialization
	public GameObject sendIterateTo;
	public string iterateMessage;
	public GameObject sendCompleteTo;
	public string completeMessage;
	public Color activeColor;
	private Color inactiveColor;
	private int currentCount = 0;
	private int maxCount;
	void Start () {
		maxCount = transform.childCount;
		foreach (Transform light in transform) {
			inactiveColor = light.GetComponent<SpriteRenderer> ().color;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		IncreaseCount ();
	}

	void IncreaseCount() {
		currentCount++;
		if (currentCount == maxCount) {
			currentCount = 0;
			foreach (Transform light in transform) {
				light.gameObject.GetComponent<SpriteRenderer> ().color = inactiveColor;

			}
			if (sendCompleteTo != null && completeMessage != null) {
				sendCompleteTo.SendMessage (completeMessage);
			}
		} else {
			int x = 0;
			foreach (Transform light in transform) {
				if (x < currentCount) {
					light.gameObject.GetComponent<SpriteRenderer> ().color = activeColor;
				}
				x++;
			}
			if (sendIterateTo != null && iterateMessage != null) {
				sendIterateTo.SendMessage (iterateMessage);
			}
		}
	}
}

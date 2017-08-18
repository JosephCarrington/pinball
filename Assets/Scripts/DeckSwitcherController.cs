using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckSwitcherController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public string layerToSwitchTo = "Default";
	public Vector2 scaleToSwitchTo = Vector2.one;
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Ball" || col.gameObject.tag == "Cheating Ball") {
			col.gameObject.layer = LayerMask.NameToLayer(layerToSwitchTo);
			col.gameObject.transform.localScale = scaleToSwitchTo;
			int sortingOrder = -1;
			if (layerToSwitchTo == "Upper Deck") {
				sortingOrder = 2;
			}
			col.gameObject.GetComponent<SpriteRenderer> ().sortingOrder = sortingOrder;
		}
			
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.magenta;
		Gizmos.DrawCube (transform.position, Vector2.one * 0.25f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSaveLightController : MonoBehaviour {

	// Use this for initialization
	private Color offColor;
	public Color onColor = Color.magenta;

	private SpriteRenderer spriteRenderer;
	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		offColor = spriteRenderer.color;
	}
	
	public void Power(bool light) {
		spriteRenderer.color = light ? onColor : offColor;
	}
}

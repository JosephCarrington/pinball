using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableEndController : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	private GameObject brain;
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		brain = GameObject.Find ("Brain");
		Button tryAgain = transform.Find ("Try Again").GetComponent<Button>();
		tryAgain.onClick.AddListener(TellBrainToReload);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EnterScreen() {
		anim.SetTrigger ("Enter Screen");
	}

	void TellBrainToReload() {
		brain.SendMessage ("ReloadTable");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanelController : MonoBehaviour {

	// Use this for initialization
	GameObject brain;
	Animator anim;
	void Start () {
		brain = GameObject.Find ("Brain");
		anim = gameObject.GetComponent<Animator> ();
		transform.Find("Reload").GetComponent<Button>().onClick.AddListener(() => brain.SendMessage("ReloadTable"));
		transform.Find("Exit Panel").GetComponent<Button>().onClick.AddListener(ExitScreen);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void EnterScreen() {
		anim.SetTrigger ("Enter Screen");
		brain.SendMessage ("OpenMenu");
	}

	void ExitScreen() {
		anim.SetTrigger ("Exit Screen");
		brain.SendMessage ("CloseMenu");
	}
}

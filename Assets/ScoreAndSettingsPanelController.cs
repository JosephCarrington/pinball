using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndSettingsPanelController : MonoBehaviour {

	// Use this for initialization
//	GameObject brain;
	GameObject settingsPanel;
	void Start () {
//		brain = GameObject.Find ("Brain");
		settingsPanel = GameObject.Find("Settings Panel");
		transform.Find("Settings").GetComponent<Button>().onClick.AddListener(TellSettingsPanelToEnter);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TellSettingsPanelToEnter() {
		settingsPanel.SendMessage("EnterScreen");
	}
}

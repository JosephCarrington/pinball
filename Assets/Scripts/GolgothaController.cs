using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayMaker;

public class GolgothaController : MonoBehaviour {

	// Use this for initialization
	private GameObject[] toggles;
	public GameObject finalGate;
	void Start () {
		toggles = GameObject.FindGameObjectsWithTag ("Toggle");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void ToggleChangeState(bool state) {
		int toggled = 0;
		foreach(GameObject toggle in toggles) {
			PlayMakerFSM fsm = toggle.GetComponent<PlayMakerFSM> ();
			bool isActive = fsm.FsmVariables.GetFsmBool ("isActive").Value;
			if (isActive) {
				toggled++;
			}
		}

		if (toggled >= 3) {
//			HingeJoint2D joint = GameObject.Find ("Latch").GetComponent<HingeJoint2D> ();
//			JointMotor2D motor = joint.motor;
//			motor.motorSpeed = -motor.motorSpeed;
//			joint.motor = motor;
//			joint.useMotor = true;
			GameObject.Find("Latch").GetComponent<Rigidbody2D>().AddTorque(1000f);
		}
	}

	void OpenFinalGate() {
//		HingeJoint2D joint = finalGate.GetComponent<HingeJoint2D> ();
//		JointMotor2D motor = joint.motor;
//		motor.motorSpeed = -motor.motorSpeed;
//		joint.motor = motor;
//		joint.useMotor = true;
		finalGate.GetComponent<Rigidbody2D>().AddTorque(1000f);
	}
}

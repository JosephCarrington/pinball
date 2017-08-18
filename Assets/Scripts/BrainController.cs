using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BrainController : MonoBehaviour {

	// Use this for initialization
	private Text scoreText;
	private int score = 0;
	public GameObject ballPrefab;
	private BallDisplayController ballDisplayController;
	public Vector2 ballSpawn;
	private GameObject tableEnd;
	private GameObject cheatingBall;

	void Start () {
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		ballDisplayController = GameObject.Find ("Balls").GetComponent<BallDisplayController>();
		SpawnBall ();
		tableEnd = GameObject.Find ("TableEnd");
	}

	
	// Update is called once per frame
	IEnumerator cheating;
	void Update () {
		
		if (Input.GetButtonDown ("Cheat")) {
			cheating = Cheat ();
			StartCoroutine (cheating);
		}
		if (Input.GetButtonUp ("Cheat")) {
			StopCoroutine (cheating);

			cheatingBall.GetComponent<Rigidbody2D> ().isKinematic = false;
		}
	}

	IEnumerator Cheat() {
		cheatingBall = GameObject.Instantiate (ballPrefab);
		cheatingBall.tag = "Cheating Ball";
		cheatingBall.GetComponent<Rigidbody2D> ().isKinematic = true;
		cheatingBall.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		while (true) {
			Vector2 newPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			cheatingBall.transform.position = newPos;
			yield return null;
		}


	}

	void EndTable() {
		tableEnd.SendMessage ("EnterScreen");
		tableEnd.transform.Find ("Text").GetComponent<Text> ().text = "Total Score: " + score;
	}

	void Win() {
		EndTable ();
	}
	void SpawnFreeBall() {
			GameObject.Instantiate (ballPrefab, ballSpawn, Quaternion.identity);
	}

	void SpawnBall() {
		if (ballDisplayController.BallCount() > 0) {
			ballDisplayController.RemoveBall ();
			GameObject.Instantiate (ballPrefab, ballSpawn, Quaternion.identity);
		} else {
			EndTable ();
		}
	}

		
	void IncreaseScore(int amt) {
		score += amt;
		scoreText.text = score.ToString();
	}

	void Pause() {
		Time.timeScale = 0f;
	}

	void Unpause() {
		Time.timeScale = 1f;
	}

	public bool menuIsOpen = false;
	// Don't fire inputs on anything but UI
	void OpenMenu() {
		menuIsOpen = true;
	}

	void CloseMenu() {
		menuIsOpen = false;
	}

	public void ReloadTable() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}

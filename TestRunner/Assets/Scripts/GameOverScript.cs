using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnGUI () {
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "Game Over");
		GUI.Label (new Rect (Screen.width / 2 - 40, 80, 80, 30), "Score: " + score);

		if (GUI.Button (new Rect (Screen.width / 2 - 40, 110, 60, 30), "Retry?")) {
			Application.LoadLevel (0);
		}
	}

}

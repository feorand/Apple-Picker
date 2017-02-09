using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public static int Score;
	public GameObject scoreText;

	public void SetScore(int score) {
		var uiText = scoreText.GetComponent<Text> ();
		uiText.text = "Score: " + score.ToString();
	}
}

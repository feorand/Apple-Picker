using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public static int Score;

	public static void SetScore() {
		var uiText = GameObject.Find("ScoreText").GetComponent<Text> ();
		uiText.text = "Score: " + Score.ToString();
	}
}

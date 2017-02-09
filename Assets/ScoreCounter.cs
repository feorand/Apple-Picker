using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public static int Score {
		get { 
			return score;
		} 
		set { 
			score = value; 
			if (score > highscore)
				highscore = value;
		}
	}

	static int highscore;
	static int score;

	public static void PrintScore() {
		var uiText = GameObject
			.Find("ScoreText")
			.GetComponent<Text> ();
		
		uiText.text = "Score: " + score + "\nHighscore: " + highscore;
	}
}

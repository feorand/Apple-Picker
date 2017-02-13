using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdater : MonoBehaviour {
	public void OnScoreChanged(int score, int highscore) {
		var uiText = GetComponent<Text>();
		uiText.text = "Score: " + score + "\nHighscore: " + highscore;
	}
}

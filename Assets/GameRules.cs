using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameRules : MonoBehaviour
{
	int basketsLeft;
	static int highscore;
	static int score;

	[System.Serializable]
	public class ScoreUpdatedEvent : UnityEvent<int, int> { }

	public ScoreUpdatedEvent ScoreUpdated;

	void Awake()
	{
		basketsLeft = GetComponent<BasketSpawner>().numberOfBaskets;
		score = 0;
	}

	void Start()
	{
		var updater = GameObject.Find("ScoreText").GetComponent<ScoreTextUpdater>();
		ScoreUpdated = new ScoreUpdatedEvent();
		ScoreUpdated.AddListener(updater.OnScoreChanged);
		ScoreUpdated.Invoke(score, highscore);
	}

	public void OnAppleCatch() {
		score += 10;
		if (score > highscore)
			highscore = score;

		ScoreUpdated.Invoke(score, highscore);
	}

	public void OnAppleDrop() {
		var apples = GameObject.FindGameObjectsWithTag("Apple");
		foreach (var apple in apples) {
			Destroy (apple);
		}

		if (basketsLeft > 0) {
			var basket = GameObject.Find("Basket(Clone)");
			Destroy (basket);
			basketsLeft -= 1;
		}

		if (basketsLeft == 0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}

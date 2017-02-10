using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	public GameObject applePrefab;
	public GameObject gameMaster;

	public float timeBetweenApples;
	float timeUntilNextApple;

	void Update () {
		if (timeUntilNextApple <= 0) { 
			spawnApple(applePrefab);
			timeUntilNextApple = timeBetweenApples;
		}

		timeUntilNextApple -= Time.deltaTime;
	}

	void spawnApple(GameObject applePrefab) {
		//var gameRules = gameMaster.GetComponent<GameRules> ();

		var apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
		//var appleCatcher = apple.GetComponent<AppleCatchNotifier> ();
		//appleCatcher.appleCaught.AddListener (gameRules.OnAppleCatch);
	}
}

using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	public GameObject applePrefab;
	public GameObject GameMaster;

	public float timeBetweenApples;
	float timeUntilNextApple;

	// Update is called once per frame
	void Update () {
		if (timeUntilNextApple <= 0) { 
			spawnApple(applePrefab);
			timeUntilNextApple = timeBetweenApples;
		}

		timeUntilNextApple -= Time.deltaTime;
	}

	void spawnApple(GameObject applePrefab) {
		var initializer = GameMaster.GetComponent<Initializer> ();

		var apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
		var appleCatcher = apple.GetComponent<AppleCatcher> ();
		appleCatcher.appleCaught.AddListener (initializer.OnAppleCatch);
	}
}

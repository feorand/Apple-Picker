using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	public GameObject applePrefab;

	public float timeBetweenApples;
	float timeUntilNextApple;

	GameObject tree;

	void Start() {
		tree = GameObject.FindWithTag ("Tree");
	}

	void Update () {
		if (timeUntilNextApple <= 0) { 
			spawnApple(applePrefab);
			timeUntilNextApple = timeBetweenApples;
		}

		timeUntilNextApple -= Time.deltaTime;
	}

	void spawnApple(GameObject applePrefab) {
		var initializer = GetComponent<Initializer> ();

		var apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = tree.transform.position;
		var appleCatcher = apple.GetComponent<AppleCatchNotifier> ();
		appleCatcher.appleCaught.AddListener (initializer.OnAppleCatch);
	}
}

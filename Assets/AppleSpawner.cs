using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	public GameObject applePrefab;

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

	void spawnApple(GameObject apple) {
		apple.transform.position = transform.position;
		Instantiate(apple);
	}
}

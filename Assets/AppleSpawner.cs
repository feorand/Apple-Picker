using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	public GameObject applePrefab;
	public float timeBetweenApples;

	void Start() {
		InvokeRepeating ("spawnApple", 0, timeBetweenApples);
	}

	void spawnApple() {
		var apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
}

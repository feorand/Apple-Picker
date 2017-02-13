using UnityEngine;

public class BasketSpawner : MonoBehaviour {
	public int numberOfBaskets;
	public GameObject basketPrefab;
	public float lowestBasketY;
	public float spaceBetweenBaskets;

	void Start () {
		Cursor.visible = false;

		var nextY = lowestBasketY;
		for (var i = 0; i < numberOfBaskets; i++) {
			var basket = Instantiate(basketPrefab) as GameObject;
			basket.transform.Translate(new Vector3(0, nextY - basket.transform.position.y, 0));
			basket.GetComponent<AppleCatchNotifier>().appleCaught.AddListener(GetComponent<GameRules>().OnAppleCatch);
			nextY += spaceBetweenBaskets;
		}
	}
}

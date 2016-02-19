using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public int enemyCount;
	public int goodGuyCount;
	public GameObject enemy2;
	public GameObject goodGuy;
	float timeCount_enemy;
	float timeCount_goodGuy;

	void Start () {
	
	}
	
	void spawnEnemy () {
		if (enemyCount < 35) {
			Vector3 spawnLocation = new Vector3 (Random.Range (-4.0f, 4.0f), 1.0f, Random.Range (-4.0f, 4.0f));
			Instantiate (enemy2, spawnLocation, Quaternion.identity);
			timeCount_enemy = 0.0f;
		}
	}

	void spawnGoodGuy () {
		Vector3 spawnLocation = new Vector3 (Random.Range (-4.0f, 4.0f), 1.0f, Random.Range (0.0f, 4.0f));
		Instantiate (goodGuy, spawnLocation, Quaternion.identity);
		timeCount_goodGuy = 0.0f;
	}


	void Update () {
		timeCount_enemy += 1.0f;
		timeCount_goodGuy += 1.0f;

		GameObject[] count = GameObject.FindGameObjectsWithTag("enemy");
		enemyCount = count.Length;
		if (timeCount_enemy >= 120.0f)
		{
			spawnEnemy ();
		}

		if (timeCount_goodGuy >= 3600.0f) {
			spawnGoodGuy ();
		}
	}
}

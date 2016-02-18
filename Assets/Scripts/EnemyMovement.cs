using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject player;
	private Rigidbody rb;
	public float speed;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		float xDirection = player.transform.position.x - transform.position.x;
		float zDirection = player.transform.position.z - transform.position.z;

		float ratio = zDirection / xDirection;

		if (xDirection > 0.0f) {
			xDirection = 1.0f;
		} else {
			xDirection = -1.0f;
		}

		if (zDirection > 0.0f) {
			zDirection = Mathf.Abs (ratio * xDirection);
		} else {
			zDirection = -Mathf.Abs (ratio * xDirection);
		}

		Vector3 finalDirection = new Vector3 (xDirection * speed, 0.0f, zDirection * speed);

		rb.AddForce (finalDirection);
	}
}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float strength;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = 0.0f;

		if (Input.GetKeyDown (KeyCode.Space) && (transform.position.y > 0.65f && transform.position.y < 0.7f)) {
			jump = 1.0f;
		}

		Vector3 finalMovement = new Vector3 (moveHorizontal * speed, jump * strength, moveVertical * speed);

		rb.AddForce (finalMovement);
	}
}

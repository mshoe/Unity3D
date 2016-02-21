using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed;
	public float strength;
	public bool onGround = true;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("ground")) {
			onGround = true;
		} else {
			onGround = false;
		}
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = 0.0f;

		if (Input.GetKeyDown (KeyCode.Space) && onGround) {
			jump = 1.0f;
            onGround = false;
		}

		Vector3 finalMovement = new Vector3 (moveHorizontal * speed, jump * strength, moveVertical * speed);

		rb.AddForce (finalMovement);
	}
}

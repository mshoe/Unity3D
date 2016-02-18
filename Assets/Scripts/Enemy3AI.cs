using UnityEngine;
using System.Collections;

public class Enemy3AI : MonoBehaviour {

	private Rigidbody rb;
	Transform tr_Player;
	float f_RotSpeed = 3.0f, f_MoveSpeed = 3.0f, f_jump = 125.0f;

	void Start () {
		tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		/* Look at Player */
		transform.rotation = Quaternion.Slerp (transform.rotation
			, Quaternion.LookRotation (tr_Player.position - transform.position)
			, f_RotSpeed * Time.deltaTime);
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("ground")) {
			rb.AddForce (Vector3.up * f_jump);
		}
	}
}

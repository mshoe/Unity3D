using UnityEngine;
using System.Collections;

public class WinDetector : MonoBehaviour {

	public int score = 0;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("enemy")) {
			Destroy (col.gameObject);
			score += 1;
		} else if (col.gameObject.CompareTag ("Player")) {
			Destroy (col.gameObject);
			score -= 9999;
		}
	}
}

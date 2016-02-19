using UnityEngine;
using System.Collections;

public class PreserveData : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
}

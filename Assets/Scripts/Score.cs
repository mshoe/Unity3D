using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public GameObject WinDetector;
	Text txt;
	private int currentScore = 0;

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}

	void Start ()
	{
		WinDetector = GameObject.Find ("WinDetector");
		txt = gameObject.GetComponent<Text>();
		txt.text = "Score: " + currentScore;
	}

	void Update()
	{
		txt.text = "Score: " + currentScore;
		currentScore = WinDetector.GetComponent<WinDetector>().score;
	}
}
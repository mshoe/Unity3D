using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Timer : MonoBehaviour {

	public Text timerLabel;
	private float time;
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		var minutes = Math.Floor(time / 60);
		var seconds = Math.Floor(time % 60);
		var fraction = (time * 100) % 100;

		timerLabel.text = string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
	}
}

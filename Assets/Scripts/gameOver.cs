using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public Texture gameOverTexture;
	public GameObject WinDetector;
	public int score;

	void Start () {
		WinDetector = GameObject.Find ("WinDetector");
		score = WinDetector.GetComponent<WinDetector>().score;
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gameOverTexture);
		GUI.TextArea (new Rect (0, 0, Screen.width/4, Screen.height/4), "Score: " + score);
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2, 150, 25),"Play Again")) 
		{
			Application.LoadLevel("minigame");
		}
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2 + 25, 150, 25),"ggwp")) 
		{
			Application.Quit();
		}
	}
}

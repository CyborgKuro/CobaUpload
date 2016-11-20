using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour {

	private bool gameOver;
	private int highScore;
	public GUIStyle style2;
	public Texture image1;
	public Camera cam;

	// Use this for initialization
	void Start () {
		gameOver = false;
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.name == "Quad1") {
			Time.timeScale = 0;
			gameOver = true;
		}
	}

	void OnGUI(){
		if (gameOver) { 
			GUI.Label (new Rect (Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.75f, Screen.height * 0.25f), "GAME OVER!!!", style2);
			if (GUI.Button (new Rect (Screen.width * 0.48f, Screen.height * 0.55f, 50f, 50f), image1)) {
				SceneManager.LoadSceneAsync ("GameScene");
				Time.timeScale = 1;
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	private int sc;
	private float sco;
	private int high;
	public GUIStyle style1;
	// Use this for initialization
	void Start () {
		high = HighScoreScript.highScores;
		//Debug.Log (high);
		sco = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
		sco += Time.deltaTime*10;
		sc = (int)sco;
		if (high < sc) {
			HighScoreScript.highScores = sc;
		}
	}

	void OnGUI(){
		string hi = high.ToString();
		string score = sc.ToString();
		GUI.Label(new Rect (Screen.width * 0.8f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), score, style1);
		GUI.Label (new Rect (Screen.width * 0.65f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), "HI"+high, style1);
	}
}

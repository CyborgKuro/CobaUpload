using UnityEngine;
using System.Collections;

public class SiangMalam : MonoBehaviour {

	public Shader HSVShader;
	public bool siang = true;
	public GameObject ob1;
	public GameObject ob2;
	private SpriteRenderer sr1; 
	private SpriteRenderer sr2;
	private int delay;
	private int delayDalamGame;


	void Start () {
		delay = 2000;
		delayDalamGame = delay;
		sr1 = ob1.GetComponent<SpriteRenderer> ();
		sr2 = ob2.GetComponent<SpriteRenderer> ();
	}

	void Update () {
		delayDalamGame--;
		if (delayDalamGame <= 0) {	
			UpdateBGColor ();
		}
	}

	void UpdateBGColor(){
		if (siang == true) {
			if (sr1.material.GetFloat ("_Val") >= 0.5f) {
				sr1.material.SetFloat ("_Val", sr1.material.GetFloat ("_Val") - 0.001f);
				sr2.material.SetFloat ("_Val", sr2.material.GetFloat ("_Val") - 0.001f);
			} else {
				delayDalamGame = delay;
				siang = false;
			}
		} else {
			if (sr1.material.GetFloat ("_Val") <= 1f) {
				sr1.material.SetFloat ("_Val", sr1.material.GetFloat ("_Val") + 0.001f);
				sr2.material.SetFloat ("_Val", sr2.material.GetFloat ("_Val") + 0.001f);
			}
			else {
				delayDalamGame = delay;
				siang = true;
			}
		}
	}
}

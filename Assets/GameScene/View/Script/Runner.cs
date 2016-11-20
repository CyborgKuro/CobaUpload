using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {

	private bool falling= false;
	private int jumpHeight =1;
	public AudioSource soundFXJump;
	private AudioSource sfxJump;
	// Use this for initialization
	void Start () {
		sfxJump = soundFXJump.GetComponent<AudioSource> ();
		PlayerPrefs.SetInt ("speed", 7);
		falling = false;
	}
		
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * PlayerPrefs.GetInt ("speed") * Time.deltaTime);
		if (Input.GetKey (KeyCode.Space)||Input.GetKey (KeyCode.UpArrow)||Input.GetKey(KeyCode.Mouse0)) {
			sfxJump.Play ();
			if ((GetComponent<Rigidbody2D> ().position.y < jumpHeight) && falling == false) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, 12);
			}
			else {
				falling = true;
			}

		}
		else {
			falling = true;
		}
	
	}
	void OnCollisionStay2D(){
		falling = false;
	}
}
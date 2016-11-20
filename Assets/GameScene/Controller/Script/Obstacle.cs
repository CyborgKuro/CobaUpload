using UnityEngine;
using System.Collections;

public abstract class Obstacle : MonoBehaviour {

	public GameObject[] ob;
	public Transform campos;
	public float gap =1.5f;
	public int obs;


	void Start () {
		ObstacleMaker ();
	}
		
	void Update () {
		transform.Translate (Vector3.right * PlayerPrefs.GetInt ("speed") * Time.deltaTime);
		GameObject go = GameObject.Find ("Quad1");
		if (campos.position.x - go.transform.position.x > 25) {
			Destroy (go);
		}
	}

	public abstract void ObstacleMaker ();

}

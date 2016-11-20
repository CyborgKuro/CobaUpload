using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerExit2D(Collider2D coll){
		float width = ((BoxCollider2D)coll).size.x;
		Vector3 pos = coll.transform.position;
		pos.x += width + 49.01f;
		if (coll.gameObject.tag == "BG1") {
			coll.transform.position = pos;
		}
		if (coll.gameObject.tag == "BG2") {
			coll.transform.position = pos;
		}
	}
}

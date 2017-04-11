using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl_1 : MonoBehaviour {
	//public Rigidbody rb;
	void Start() {

	}
	void FixedUpdate() {
		if (Input.GetKeyDown ("a")) {
			StartCoroutine (handle());
		}

		//rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
	}

	IEnumerator handle(){
		transform.localScale = new Vector3 (1, 0.25f, 1);
		transform.Translate (Vector3.down * .5f);
		yield return new WaitForSecondsRealtime (.05f);
		transform.localScale = new Vector3 (1, 0.5f, 1);
		transform.Translate (Vector3.up * .5f);
	}

}

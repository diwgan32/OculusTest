using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour {
	//public Rigidbody rb;
	void Start() {

	}
	void FixedUpdate() {
		if (Input.GetKeyDown (gameObject.name)) {
			StartCoroutine (handle());
		}/*
		if (Input.GetKeyUp ("a")) {
			StartCoroutine (handleUp ());
		}
*/
		//rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
	}

	IEnumerator handle(){
		
		transform.Translate (Vector3.back * 1f);
		yield return new WaitForSecondsRealtime (.05f);
		transform.Translate (Vector3.forward * 1f);
	}/*
	IEnumerator handleUp(){

		transform.Translate (Vector3.forward * 1f);
*/

}

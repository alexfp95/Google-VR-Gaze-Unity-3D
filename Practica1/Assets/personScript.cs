using UnityEngine;
using System.Collections;

public class personScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter (Collision collision) {
		Debug.Log ("Choco con: " + collision.gameObject.name);
	}
}

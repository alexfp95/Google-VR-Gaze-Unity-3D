using UnityEngine;
using System.Collections;

public class CasetaVR : MonoBehaviour, IGvrGazeResponder {

	public void OnGazeEnter () {
		Debug.Log ("Gaze: Enter");
		transform.Rotate (0, 0, 45);
	}

	public void OnGazeExit () { 
		Debug.Log ("Gaze: Exit");
		transform.Rotate (0, 0, 45);
	}

	public void OnGazeTrigger () {
		Debug.Log ("Gaze: Trigger");
		transform.Rotate (0, 0, 45);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

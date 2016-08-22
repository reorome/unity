using UnityEngine;
using System.Collections;

public class cue_BehaviourScriptNewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		this.transform.Rotate(1, 1, 1);
		Vector3 v = this.transform.position;
		if (Input.GetKey(KeyCode.LeftArrow)){
			v.x -= 0.05f;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			v.x += 0.05f;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			v.z += 0.05f;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			v.z -= 0.05f;
		}
		this.transform.position = v;
	}
}

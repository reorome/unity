using UnityEngine;
using System.Collections;

public class PocketBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		print ("aaaa");
		if (other.gameObject.tag == "ball") {
			Destroy(other.gameObject);
		}
	}

}

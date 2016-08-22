#pragma strict

function Start () {

}

function Update () {
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
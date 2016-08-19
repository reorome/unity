using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class GameManagerScript : MonoBehaviour {

	int mainball;
	bool player1playing;
	bool player2playing;
	int ballnum = 9;

	List<bool> balls = new List<bool>();

	GameProcessEnumScript processEnum;

	// Use this for initialization
	void Start () {
		//ballオブジェクトの生成

		mainball = 1;

		for (int i = 0; i < ballnum; i++) {
			balls.Add(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}

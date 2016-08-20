﻿using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;

//NetworkManagerクラスを継承する(NetworkBehaviourではないので注意)
public class NetworkManager_Custom : NetworkManager {


	//ButtonStartHostボタンを押した時に実行
	//IPポートを設定し、ホストとして接続
	public void StartupHost()
	{
		SetPort();
		NetworkManager.singleton.StartHost();
	}

	//ButtonJoinGameボタンを押した時に実行
	//IPアドレスとポートを設定し、クライアントとして接続
	public void JoinGame()
	{
		SetIPAddress();
		SetPort();
		NetworkManager.singleton.StartClient();
	}

	void SetIPAddress()
	{
		//Input Fieldに記入されたIPアドレスを取得し、接続する
		string ipAddress = GameObject.Find("InputFieldIPAddress").transform.FindChild("Text").GetComponent<Text>().text;
		NetworkManager.singleton.networkAddress = ipAddress;
	}

	//ポートの設定
	void SetPort ()
	{
		NetworkManager.singleton.networkPort = 7777;
	}
}

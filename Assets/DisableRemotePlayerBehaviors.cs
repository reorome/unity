using UnityEngine;
using UnityEngine.Networking;

public class DisableRemotePlayerBehaviors : NetworkBehaviour {
	
	public Behaviour[] behaviours;

	void Start()
	{
		// 登録されたコンポーネントをリモート側で disabled にする
		if (!isLocalPlayer) {
			foreach (var behaviour in behaviours) {
				behaviour.enabled = false;
			}
		}
	}
}

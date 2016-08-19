using UnityEngine;
using System.Collections;
//Enumに必要
using System;

public class enumScript : MonoBehaviour {

	public enum Command {
		ATTACK = 1,		//内部にint型を指定できる。
		GUARD,			//指定されていない場合は前の数＋１。
		MAGIC,
		ITEM
	}
	public Command cmdType;

	void Update ()
	{
		//列挙した文字を取得
		if (Input.GetKeyDown ("a")) {
			Debug.Log(cmdType);
		}
		//列挙数を取得
		if (Input.GetKeyDown ("b")) {
			int nagasa = Enum.GetNames(typeof(Command)).Length;
			Debug.Log(nagasa);
		}
		//列挙した文字を全て取得
		if (Input.GetKeyDown ("c")) {
			foreach(Command cmd in Enum.GetValues(typeof(Command))){
				Debug.Log(cmd);
			}
		}
		//enumを１つ指定し、EnumUseメソッドを呼び出す
		if (Input.GetKeyDown ("d")) {
			string enumString = EnumUse(Command.ITEM);
			Debug.Log(enumString);
		}
	}

	String EnumUse (Command command)
	{
		if (command == Command.ATTACK) {
			return "【"+(int)Command.ATTACK+"】攻撃します！";
		} else if (command == Command.GUARD) {
			return "【"+(int)Command.GUARD+"】防御します！";
		} else if (command == Command.MAGIC) {
			return "【"+(int)Command.MAGIC+"】魔法を使います！";
		} else if (command == Command.ITEM) {
			return "【"+(int)Command.ITEM+"】アイテムを使います！";
		}
		return null;
	}
}
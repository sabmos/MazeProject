using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextUpdate : MonoBehaviour {

	public Text UIKeyText;
	public Text UICoinText;

	bool hasKey = false;
	int coinCount = 0;

	// Use this for initialization
	void Start () {
		UIKeyText.text = "Key:\nNo";
		UICoinText.text = "Coins:\n" + coinCount + "/7";
	}
	
	// Update is called once per frame
	void Update () {
		if (hasKey) {
			UIKeyText.text = "Key:\nYes";
		}
	}

	public void foundKey () {
		hasKey = true;
	}

	public void addCoin() {
		coinCount += 1;
		UICoinText.text = "Coins:\n" + coinCount + "/7";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTest : MonoBehaviour {
	public TextMeshProUGUI dialogueText;

	void Start() {

	}

	void Update() {		
		dialogueText.text = "The quick brown <color=red>" + "fox" + "</color> jumped over the lazy <color=red>" + "dog" + "</color>.";
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Keybind {
	public string keyName;
	public KeyCode key;

}

public class KeybinderManager : MonoBehaviour {

	public Keybind[] keybinds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void restartLevel() {
		// Reload the scene, resetting the game
		Prospector.S.Invoke("ReloadLevel", 0.25f);
	}

	// Update is called once per frame
	void Update () {
		
	}
}

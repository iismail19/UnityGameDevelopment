using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level load requested " + name);
		Application.LoadLevel(name); // this will load the specified scence/level
	}

	// Application.Quit() does not work in web-build or debugg mode, works great for console & PC/Mac/Linux
    // for app dev dont quit the application your self, have user or OS manage applicaitons
	public void QuitRequest(){
		Debug.Log("Requesting Quit Game");
		Application.Quit();

	}
}

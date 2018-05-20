using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text mytext; 
	private String pokemon_name;
	private int pokemon_level;


	// Use this for initialization
	void Start () {
		mytext.text = "Welcome to pokemon World";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

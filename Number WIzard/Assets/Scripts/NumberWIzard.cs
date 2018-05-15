using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWIzard : MonoBehaviour {

	int max;
    int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		// Check for Key Press:
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // print("up arrow pressed");
            min = guess;
			NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // print("down arrow pressed");
            max = guess;
			NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
			StartGame();

        }
	}

	void StartGame(){
		max = 1000;
		min = 500;
		guess = 500;

		print("==========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");


        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, Down = lower, return or enter = equals");
		max = max + 1; // bc if your number is 1000, (min + max) / 2 rounds down to 999.
	}
	void NextGuess(){
		guess = (max + min) / 2;
        print("Higher or lower than " + guess + " ? ");
		print("Up = higher, Down = lower, return or enter = equals");
	}

}

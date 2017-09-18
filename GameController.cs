using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    float time;
    bool printedMessage;

    // Use this for initialization
    void Start () {
	   print ("The game has begun!");

       printedMessage = false;
	}

	// Update is called once per frame
	void Update () {
    if (Time.time > 3 && printedMessage == false) {
		//stuff the happens if true time.time is a floating point numbers, greater or less than
		print ("It has been three seconds!");
		printedMessage = true;
	         }
		}
}

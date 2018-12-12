using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeCounter : MonoBehaviour {

<<<<<<< HEAD
	Text timeUI;

	float startTime;
	float ellapsedTime;
	bool startCounter;
=======
	Text timeUI;//reference to the time counter UI 

	float startTime;//time when the player clicks on play
	float ellapsedTime;//the ellapsed time after the user clicks on play
	bool startCounter;//flag to start the counter
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108

	int minutes;
	int seconds;

<<<<<<< HEAD
	void Start () {
		startCounter = false;

		timeUI = GetComponent<Text> ();
	}

=======
	// Use this for initialization
	void Start () {
		startCounter = false;

		//get the Text UI component from this gameObject
		timeUI = GetComponent<Text> ();
	}

	//Function to start the time counter
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	public void StartTimeCounter() {
		startTime = Time.time;
		startCounter = true;
	}

<<<<<<< HEAD
=======
	//Stop the time counter
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
	public void StopTimeCounter() {
		startCounter = false;
	}
	
<<<<<<< HEAD
	void Update () {
		if (startCounter) {
=======
	// Update is called once per frame
	void Update () {
		if (startCounter) {
			//computer the ellapsed time
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
			ellapsedTime = Time.time - startTime;

			minutes = (int)ellapsedTime / 60;
			seconds = (int)ellapsedTime % 60;

<<<<<<< HEAD
=======
			//update the time counter UI Text
>>>>>>> 83be763ca2c2e1362e07009c79bde844a0214108
			timeUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);
		}
	}
}

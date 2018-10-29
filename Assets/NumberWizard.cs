using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour 
{
	public int hiNum = 1000;
	public int loNum = 1;
	public string name = "fuckface";
	public int guess = 500;



	// Use this for initialization
	void Start () 
	{
		Debug.Log ("Welcome to Number Wizard");
		Debug.Log ("Please pick a number, " + name);
		Debug.Log ("Your highest number is: "+ hiNum);
		Debug.Log ("Your lowest number is: "+ loNum);
		Debug.Log ("Tell Me if Your number is higher or lower than" + guess);
		Debug.Log ("Up Arrow Key = higher, Down Arrow Key = lower, enter = correct");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			Debug.Log("Up Arrow key was pressed.");
			loNum = guess;
			Debug.Log (guess);

		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			Debug.Log("Down Arrow key was pressed.");
			hiNum = guess;
			Debug.Log (guess);

		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("Enter key was pressed.");
		}
	}
}

using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {

	public int timeRemaining;
	// Use this for initialization
	void Awake () 
	{
		timeRemaining = 150;

		InvokeRepeating ("timeDown", 1f, 1f);
	}
	
	// Update is called once per frame
	

	private void timeDown()
	{
		timeRemaining --;

		if(timeRemaining == 0)
		{
			//Player dies
		}

		Debug.Log (timeRemaining);
	}
}

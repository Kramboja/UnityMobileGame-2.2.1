using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {

	public int timeRemaining;

	private Text _timeRemainingText;
	// Use this for initialization
	void Awake () 
	{
		_timeRemainingText = GetComponent<Text> ();
		timeRemaining = 150;

		_timeRemainingText.text =  "" + timeRemaining;// + timeRemaining;	//timeRemaining.ToString();

		InvokeRepeating ("timeDown", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update()
	{

	}

	private void timeDown()
	{
		timeRemaining --;

		if(timeRemaining == 0)
		{
			//Player dies
		}
		_timeRemainingText.text =  "" + timeRemaining;// + timeRemaining;	//timeRemaining.ToString();
		Debug.Log (timeRemaining);
	}
}

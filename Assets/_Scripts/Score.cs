using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int _TimeRemaining;
	private int _Score;

	public void updateScore()
	{
		_TimeRemaining = GetComponent<TimeScript>().timeRemaining;// get how much time = remaining

		Debug.Log (_TimeRemaining + " / " + _Score);
		_Score = Mathf.FloorToInt (1000 - (10000f / _TimeRemaining));
		Debug.Log (_TimeRemaining + " / " + _Score);

	}

	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.A))
		{
			updateScore();
		}
	}
}

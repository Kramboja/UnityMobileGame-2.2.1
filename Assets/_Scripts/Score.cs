using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private int _TimeRemaining;
	private int _Score;

	public GameObject timeObject;

	private Text _yourScore;

	public void updateScore()
	{
		_TimeRemaining = timeObject.GetComponent<TimeScript>().timeRemaining;// get how much time = remaining

		Debug.Log (_TimeRemaining + " / " + _Score);
		_Score -= 6;
		//_Score = Mathf.FloorToInt (1000 - (100000f / _TimeRemaining)) + 67;
		Debug.Log (_TimeRemaining + " / " + _Score);

		_yourScore.text =  "" + (_Score + 100) ;// + timeRemaining;	//timeRemaining.ToString();
	}

	void Awake () 
	{
		_Score = 900;
		_yourScore = GetComponent<Text> ();
		_yourScore.text =  "" + (_Score + 100) ;// + timeRemaining;	//timeRemaining.ToString(); 

		InvokeRepeating ("updateScore", 1f, 1f);
	}
}

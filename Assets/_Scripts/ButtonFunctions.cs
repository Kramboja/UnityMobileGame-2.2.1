using UnityEngine;
using System.Collections;

public class ButtonFunctions : MonoBehaviour {

	public void StartGame()
	{
		Debug.Log ("test");
		Application.LoadLevel (1);
	}

	public void MainMenu ()
	{
		Application.LoadLevel (0);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}

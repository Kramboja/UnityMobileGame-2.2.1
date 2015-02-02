using UnityEngine;
using System.Collections;

public class BtnBehaviour : MonoBehaviour {

	public int dir;
	private int dirSaved;
	public Transform player;
	PlayeController playerController;

	void Start () {
		playerController = player.GetComponent<PlayeController> ();

		dirSaved = dir;
	}

	public void OnDown(){
		dir = dirSaved;
		playerController.dir = dir;
		playerController.move = true;
	}
	
	public void OnUp(){
		playerController.dir = 0;
		playerController.move = false;
	}
	public void Jump(){
		playerController.jump = true;
	}
	public void JumpOff(){
		playerController.jump = false;
	}
}

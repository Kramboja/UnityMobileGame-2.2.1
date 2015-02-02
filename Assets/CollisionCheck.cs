using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

	public Transform player;
	PlayeController controller;

	void Start(){
		controller = player.GetComponent<PlayeController> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Platform") {
			controller.counter = 0;
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public Transform player;
	
	private Vector3 offset;
	
	void Start()
	{
		offset = transform.position - player.position; // berekent het verschil tussen player en positie
	}
	
	void Update()
	{
		transform.position = player.position + offset; // camera blijft de player volgen
	}
}

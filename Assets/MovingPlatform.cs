using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	private float speed = 3f;
	void Update () {
		if(transform.position.y <= -3.90){
			speed = 3f;
		} else if(transform.position.y >= 17){
			speed = -3f;
		}
		transform.Translate(new Vector2(0f,1f) * speed * Time.deltaTime);
	}
}

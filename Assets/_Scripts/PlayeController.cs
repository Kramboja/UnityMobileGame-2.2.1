using UnityEngine;
using System.Collections;

public class PlayeController : MonoBehaviour {

	public float speed = 5f;
	public int jumpHeight = 500;
	public int counter = 0;
	Animator anim;
	//Vector3 player;

	public GameObject jumper;

	public bool move;
	public bool jump;
	public bool key;
	public int dir;

	void Start(){
		anim = GetComponent<Animator> ();
		jumper.SetActive (false);
	}

	void Update(){
		if (move) {
			anim.SetBool ("walking", true);
			anim.SetBool ("Idle", false);
			anim.SetBool ("Jumping", false);
			transform.Translate(new Vector3(dir,0f,0f) * speed * Time.deltaTime);
		} else {
			anim.SetBool ("walking", false);
			anim.SetBool ("Jumping", false);
			anim.SetBool ("Idle", true);
		}

		
		if (jump) {
			counter ++;
			print(counter);
			if(counter <= 5){
				rigidbody2D.AddForce(new Vector2(0,jumpHeight), ForceMode2D.Force);
			}
		} 

		if (dir < 0) {
			transform.localScale = new Vector3(-1f, 1f, 0);
		} else if(dir > 0){
			transform.localScale = new Vector3(1f, 1f, 0);
		} else if(dir == 0){
			transform.localScale = transform.localScale;
		}

		if (key) {
			jumper.SetActive(true);	
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Coin") {
			Destroy(other.gameObject);
			key = true;
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		//print ("collision: " + other.gameObject.tag);

		if (other.gameObject.tag == "platform") {
			counter = 0;	
		}
	}
	
}

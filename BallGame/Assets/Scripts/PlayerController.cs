using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text scoreText;

	private Rigidbody rbody;
	private int score;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal") * speed;
		float y = Input.GetAxisRaw ("Vertical") * speed;
		Vector3 force = new Vector3 (x, 0, y);
		rbody.AddForce (force);
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Collectable") {
			Destroy (col.gameObject);
			score++;
			scoreText.text = "Score: " + score;
		}
	}
}

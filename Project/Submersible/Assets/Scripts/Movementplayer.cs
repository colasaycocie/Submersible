using UnityEngine;
using System.Collections;

public class Movementplayer : MonoBehaviour {

	public float speed = 1.0f;
	public float topSpeed = 5.0f;
	public float slowSpeed = 1.2f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		var move = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		rb.velocity += move * speed * Time.deltaTime;

		if (rb.velocity.magnitude > topSpeed)
			rb.velocity = rb.velocity.normalized * topSpeed;

		if (Input.GetAxisRaw ("Horizontal") == 0) {
			rb.velocity = new Vector2 (Mathf.Lerp(rb.velocity.x, 0f, slowSpeed * Time.deltaTime), rb.velocity.y);
		}
		if (Input.GetAxisRaw ("Vertical") == 0) {
			rb.velocity = new Vector2 (rb.velocity.x, Mathf.Lerp(rb.velocity.y, 0f, slowSpeed * Time.deltaTime));
		}	
	}
}

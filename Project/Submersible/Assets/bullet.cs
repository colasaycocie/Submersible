using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public float speed = 1;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (speed, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}
}

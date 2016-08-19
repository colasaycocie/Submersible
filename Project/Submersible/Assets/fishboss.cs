using UnityEngine;
using System.Collections;

public class fishboss : MonoBehaviour {

	private int health = 5;

	// Use this for initialization
	void Start () {

		FindObjectOfType (typeof (thingsdothings));

	}

	// Update is called once per frame
	void Update () {

		if (health <= 0) 
		{

			Destroy (gameObject);

			thingsdothings.win = true;
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "bullet") 
		{
			health--;

			Destroy (col.gameObject);


		}
	}

}
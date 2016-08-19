using UnityEngine;
using System.Collections;

public class Otherthinghealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D cola)
	{

		if (cola.tag == "bullet") 
		{

			Destroy (cola.gameObject);

		}

	}

}

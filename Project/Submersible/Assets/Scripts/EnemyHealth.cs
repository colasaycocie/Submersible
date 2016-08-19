using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "bullet") 
		{
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	}

}

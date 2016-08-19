using UnityEngine;
using System.Collections;

public class thingsdothings : MonoBehaviour {

	public static bool win = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (win == true) 
		{

			Destroy (gameObject);

		}

	}
}

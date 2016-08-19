using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public float delayTime = 0f;
	public  Text AmmoText;

	public static int ammo = 3;

	private float counter = 0f;

	// Use this for initialization
	void Start () 
	{
		AmmoText.text = ammo.ToString();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Space) && counter > delayTime) 
		{

			if (ammo > 0) 
			{
				ammo -= 1;
				Instantiate (bullet, transform.position, transform.rotation);
				counter = 0;
			}

		}

		counter += Time.deltaTime;
		AmmoText.text = ammo.ToString();


	}



}

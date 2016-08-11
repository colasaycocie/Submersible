using UnityEngine;
using System.Collections;

public class Enemymovement : MonoBehaviour
{


	void Start ()
	{
		
	}

	void FixedUpdate ()
	{

	


	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Waypoint1") 
		{
			transform.localRotation = Quaternion.Euler (0, 180, 0);
		}
		if (col.tag == "Waypoint2") 
		{
			transform.localRotation = Quaternion.Euler (0, 0, 0);
		}
	}

	}
using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	public float health = 10.0f;
	int damageAmount;
	int damageTime;

	public GameObject sub;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0.0f) {
			Debug.Log ("Player destroyed");

			StartCoroutine (DamageOverTimeCoroutine2 (1f));
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			StartCoroutine (DamageOverTimeCoroutine (1f));

		}
	}

	void OnCollisionExit2D(Collision2D collisionInfo)
	{

		StopAllCoroutines();

	}

	IEnumerator DamageOverTimeCoroutine(float wait)
	{
		while (health >= 0)
		{
			health -= 1.0f;
			Debug.Log (health);
			yield return new WaitForSeconds (1f);
		}

	}

	IEnumerator DamageOverTimeCoroutine2(float wait)
	{
		while (health <= 0)
		{
			sub.GetComponent<Movementplayer> ().enabled = false;
			yield return new WaitForSeconds (3f);
			Destroy (gameObject);
		}

	}

}


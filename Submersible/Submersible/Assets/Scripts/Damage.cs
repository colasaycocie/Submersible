using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	public float health = 10.0f;
	int damageAmount;
	int damageTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0.0f) {
			Destroy (gameObject);
			Debug.Log ("Player destroyed");
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			StartCoroutine (DamageOverTimeCoroutine (1f));
		}
	}

	void OnCollisionExit(Collision collisionInfo)
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

}


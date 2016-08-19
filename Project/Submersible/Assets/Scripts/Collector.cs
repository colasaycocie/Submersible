using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collector : MonoBehaviour {


	private int numberofCoins = 0;
	public Text numberofCoinsText;

	public int torpedosAmount = 0;
	public Text numberofTorpedosText;

	public AudioClip coinSound;
	public AudioClip ammoSound;
	public AudioClip healthSound;
	private AudioSource pickupAudio;

	public Damage myHealthScript;
	public float healthIncrease = 1f;

	public HealthBar myHealthBar;




	// Use this for initialization
	void Awake () 
	{
		GameObject.FindObjectOfType (typeof(Shoot));

		pickupAudio = GetComponent<AudioSource> ();

		myHealthScript = myHealthScript.GetComponent<Damage> ();

		myHealthBar = myHealthBar.GetComponent<HealthBar> ();


	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Coins")) 
		{

			pickupAudio.clip = coinSound;
			pickupAudio.Play ();

			Destroy (other.gameObject);
			++numberofCoins;

			numberofCoinsText.text = numberofCoins.ToString ();

			Debug.Log ("Number of Coins: " + numberofCoins);

		}


		if (other.gameObject.CompareTag ("Ammo")) 
		{

			pickupAudio.clip = ammoSound;
			pickupAudio.Play ();

			Destroy (other.gameObject);
			Shoot.ammo++;

		}

		if (other.gameObject.CompareTag ("Health") && myHealthBar.Health.fillAmount < 1f) 
		{
			pickupAudio.clip = healthSound;
			pickupAudio.Play ();

			myHealthScript.health += healthIncrease;

			myHealthBar.GainHealth ();

			Debug.Log ("Health : " + healthIncrease);

			Destroy (other.gameObject);

		}

	}
}

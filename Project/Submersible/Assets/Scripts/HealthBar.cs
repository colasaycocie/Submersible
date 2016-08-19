using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour {

	public Image Health;

	// Use this for initialization
	void Start () 
	{
		Health = GetComponent<Image> ();

	}
	
	public void LoseHealth()
	{

		Health.fillAmount -= 0.1f;
	}

	public void GainHealth()
	{
		Health.fillAmount += 0.1f;
	}
}

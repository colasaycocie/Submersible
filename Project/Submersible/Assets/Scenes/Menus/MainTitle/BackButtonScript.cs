using UnityEngine;
using System.Collections;

public class BackButtonScript : MonoBehaviour {

	public GameObject[] deactivateObjects;

	public GameObject[] activateObjects;

	private AudioSource buttonAudio;

	void Awake () 
	{
		buttonAudio = GetComponent<AudioSource> ();

	}

	public void ResumeScreenPressed()
	{
		Time.timeScale = 1;

		buttonAudio.Play ();
		AudioListener.volume = 1f;


		foreach (var item in activateObjects) 
		{
			item.SetActive (true);
		}

		foreach (var item in deactivateObjects) 
		{
			item.SetActive (false);

		}

	}
}
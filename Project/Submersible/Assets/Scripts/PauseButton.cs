using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

	public GameObject[] deactivateObjects;

	public GameObject[] activateObjects;

	private AudioSource buttonAudio;

	void Start () 
	{
		buttonAudio = GetComponent<AudioSource> ();

	}

	public void PauseScreenPressed()
	{
		Time.timeScale = 0;

		buttonAudio.Play ();
		AudioListener.volume = 0.3f;

		foreach (var item in deactivateObjects) 
		{
			item.SetActive (false);

		}

		foreach (var item in activateObjects) 
		{
			item.SetActive (true);
		}



	}
}

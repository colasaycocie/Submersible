using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour {

	public GameObject activeFade;

	private AudioSource buttonAudio;

	public string SceneName;

	void Awake()
	{
		buttonAudio = GetComponent<AudioSource> ();

	}


	public void PlayScene()
	{
		activeFade.SetActive (true);

		Time.timeScale = 1;

		AudioListener.volume = 1f;

		buttonAudio.Play ();

		StartCoroutine (LoadGameScene ());
	}



	IEnumerator LoadGameScene()
	{

		yield return new WaitForSeconds (2f);

		SceneManager.LoadScene (SceneName);
	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour {

	public void QuitGame()
	{


		Application.Quit ();
		Debug.Log ("Quit");



	}
}

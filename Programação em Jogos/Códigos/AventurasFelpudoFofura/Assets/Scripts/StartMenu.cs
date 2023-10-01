using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!

public class StartMenu : MonoBehaviour
{

	public void OnPlayButton ()
	{
		SceneManager.LoadScene("BeginningCinematic"); // First cinematic
	}

	public void OnCreditsButton ()
	{
		SceneManager.LoadScene("CreditsScene"); // Credits
	}

	public void OnQuitButton ()
	{
		Application.Quit();
	}

}
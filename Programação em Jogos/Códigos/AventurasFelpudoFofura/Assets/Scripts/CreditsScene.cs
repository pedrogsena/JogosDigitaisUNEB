using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!

public class CreditsScene : MonoBehaviour
{

	public void OnBackButton ()
	{
		SceneManager.LoadScene("StartMenu"); // StartMenu
	}

}
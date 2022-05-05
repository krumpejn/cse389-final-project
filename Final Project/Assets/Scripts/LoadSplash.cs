using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSplash : MonoBehaviour
{
	public string nextSceneName;

	public void OnMyButtonClick()
	{
		nextSceneName = "SplashScreenScene 1";
		SceneManager.LoadScene(nextSceneName);
	}
}

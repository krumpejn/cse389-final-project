using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHowTo : MonoBehaviour
{
	public string nextSceneName;

	public void OnMyButtonClick()
	{
		nextSceneName = "HowToPlay";
		SceneManager.LoadScene(nextSceneName);
	}
}

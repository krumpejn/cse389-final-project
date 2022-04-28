using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneLoader : MonoBehaviour
{
	public string nextSceneName;

	public void OnMyButtonClick()
	{
		nextSceneName = "City Streets";
		SceneManager.LoadScene(nextSceneName);
	}
}

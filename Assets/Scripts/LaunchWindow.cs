using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchWindow : MonoBehaviour
{
	public GameObject slogan1;

	public GameObject slogan2;

	public GameObject black;

	private void Start()
	{
		if (DateTime.Now.TimeOfDay.Hours > 12)
		{
			slogan1.SetActive(value: false);
			slogan2.SetActive(value: true);
		}
		else
		{
			slogan1.SetActive(value: true);
			slogan2.SetActive(value: false);
		}
		Invoke("CutToBlack", 3f);
	}

	private void CutToBlack()
	{
		black.SetActive(value: true);
		Invoke("LoadNextScene", 6f);
	}

	private void LoadNextScene()
	{
		SceneManager.LoadScene("Intro2", LoadSceneMode.Single);
	}
}

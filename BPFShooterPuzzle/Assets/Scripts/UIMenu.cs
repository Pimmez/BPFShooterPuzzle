using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public void PlayGame(string levelName)
	{
		SceneManager.LoadScene(levelName);
	}

	public void RestartLevel(string levelName)
	{
		SceneManager.LoadScene(levelName);
	}

	public void ReturnMenu(string levelName)
	{
		SceneManager.LoadScene(levelName);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
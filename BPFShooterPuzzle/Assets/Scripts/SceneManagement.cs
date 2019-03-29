using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
	public void SceneLoader(string loadScene)
	{
		SceneManager.LoadScene(loadScene);		
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
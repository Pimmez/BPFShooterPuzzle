using UnityEngine;

public class StartUIManager : MonoBehaviour
{
	[SerializeField] private SceneManagement sceneManagement;

	public void StartGame()
	{
		sceneManagement.SceneLoader("");
	}

	public void Options()
	{
		
	}

	public void QuitGame()
	{
		sceneManagement.QuitGame();
	}
}
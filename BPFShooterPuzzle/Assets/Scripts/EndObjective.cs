using UnityEngine;
using UnityEngine.SceneManagement;

public class EndObjective : MonoBehaviour
{
	[SerializeField] private string LoadScene;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tags.Player)
		{
			SceneManager.LoadScene(LoadScene);
		}
	}
}

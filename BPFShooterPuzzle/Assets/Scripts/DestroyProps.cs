using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyProps : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tags.Player)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			SceneManager.LoadScene("LoseScreen");
		}
		Destroy(other);
	}
}

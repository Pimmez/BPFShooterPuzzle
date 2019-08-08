using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractEndProp : MonoBehaviour
{
	[SerializeField] private string levelName;
	[SerializeField] private GameObject worldCanvas;
	private float radius = 3;
	private Collider[] hitColliders;
	private AudioManager audioManager;
	private bool soundCheck = true;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void FixedUpdate()
	{
		hitColliders = Physics.OverlapSphere(this.gameObject.transform.position, radius);
		if(hitColliders.Length == 3)
		{
			worldCanvas.SetActive(true);
			if(soundCheck)
			{
				audioManager.PlayAudioOnlyOnce(2);
				soundCheck = false;
			}
			if (Input.GetKeyDown(KeyCode.E))
			{
				SceneManager.LoadScene(levelName);
			}
		}
		else
		{
			worldCanvas.SetActive(false);
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(this.gameObject.transform.position, 3);
	}
}
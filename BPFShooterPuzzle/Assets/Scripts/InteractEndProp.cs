using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractEndProp : MonoBehaviour
{
	[SerializeField] private string levelName;
	private float radius = 3;
	private Collider[] hitColliders;
	private AudioManager audio;
	private bool soundCheck = true;

	private void Start()
	{
		audio = FindObjectOfType<AudioManager>();
	}

	private void Update()
	{
		hitColliders = Physics.OverlapSphere(this.gameObject.transform.position, radius);
		if(hitColliders.Length == 3)
		{
			if(soundCheck)
			{
				audio.PlayAudioOnlyOnce(2);
				soundCheck = false;
			}
			if (Input.GetKeyDown(KeyCode.E))
			{
				SceneManager.LoadScene(levelName);
			}
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(this.gameObject.transform.position, 3);
	}
}
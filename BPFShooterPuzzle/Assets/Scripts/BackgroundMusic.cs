using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
	[SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
	private void Awake()
    {
		audioSource.Play();
    }

    // Update is called once per frame
    private void Update()
    {
		DontDestroyOnLoad(this.gameObject);
		if(SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "LoseScreen" || SceneManager.GetActiveScene().name == "WinScreen")
		{
			audioSource.Stop();
		}
    }
}
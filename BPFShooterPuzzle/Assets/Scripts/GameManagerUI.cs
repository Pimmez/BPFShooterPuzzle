using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI ammo;
	[SerializeField] private TextMeshProUGUI timer;
	[SerializeField] private float timeLeft = 200;
	[SerializeField] private Gun gun;
	[SerializeField] private GameObject miniHud;
	private int min;
	private int sec;
	private bool isShowing;

	//DISPLAY AMOUNT OF HOOPS PER LEVEL AND DECREASE THEM WHEN COMPLETED

	private void Start()
	{
		miniHud.SetActive(false);
		gun = FindObjectOfType<Gun>();

		ammo.text = "" + gun.Magazine;

		min = Mathf.FloorToInt(timeLeft / 60);
		sec = Mathf.FloorToInt(timeLeft % 60);

		timer.text = min.ToString("00" + ":" + sec.ToString("00"));
	}

	private void Update()
	{
		TimerUpdate();
		UIAmmoUpdate();
		MiniHUDActions();
	}

	private void TimerUpdate()
	{
		min = Mathf.FloorToInt(timeLeft / 60);
		sec = Mathf.FloorToInt(timeLeft % 60);
		timer.text = min.ToString("00") + ":" + sec.ToString("00");
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
		{
			SceneManager.LoadScene("LoseScreen");
		}
	}

	private void MiniHUDActions()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			isShowing = !isShowing;
			miniHud.SetActive(isShowing);

			if(isShowing)
			{
				Time.timeScale = 0;
			}
			else
			{
				Time.timeScale = 1;
			}
		}

		if(miniHud.activeInHierarchy)
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				Time.timeScale = 1;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
			if (Input.GetKeyDown(KeyCode.X))
			{
				Time.timeScale = 1;
				SceneManager.LoadScene("Menu");
			}
		}
	}
		
	private void UIAmmoUpdate()
	{
		ammo.text = "" + gun.Magazine;
	}
}
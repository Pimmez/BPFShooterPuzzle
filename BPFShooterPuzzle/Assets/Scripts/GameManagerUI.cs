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
	private int min;
	private int sec;

	//DISPLAY AMOUNT OF HOOPS PER LEVEL AND DECREASE THEM WHEN COMPLETED

	private void Start()
	{
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

	private void UIAmmoUpdate()
	{
		ammo.text = "" + gun.Magazine;
	}
}
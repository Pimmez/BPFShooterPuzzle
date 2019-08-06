using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI ammo;
	[SerializeField] private TextMeshProUGUI timer;
	private float timeLeft = 70;

	private void Start()
	{
		timer.text = "0:00";
	}

	private void Update()
	{
		TimerUpdate();
	}

	private void TimerUpdate()
	{
		timeLeft -= Time.deltaTime;
		timer.text = (timeLeft).ToString("0");
		if(timeLeft < 0)
		{
			//DOE IETS
		}
	}

	private void UIAmmoUpdate(int magazine)
	{
		ammo.text = "" + magazine;
	}

	private void OnEnable()
	{
		Gun.AmmoEvent += UIAmmoUpdate;
	}

	private void OnDisable()
	{
		Gun.AmmoEvent -= UIAmmoUpdate;
	}
}
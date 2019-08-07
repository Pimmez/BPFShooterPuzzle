using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
	[SerializeField] private Color col;
	[SerializeField] GameObject hoop;
	[SerializeField] private HoopHolder hoopHolder;
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
		hoopHolder = FindObjectOfType<HoopHolder>();
		hoopHolder.hoops.Add(this.gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tags.Projectile)
		{
			hoopHolder.hoops.Remove(this.gameObject);
			hoop.GetComponent<Renderer>().material.color = col;
			audioManager.PlayAudioOnce(1);
		}
	}
}
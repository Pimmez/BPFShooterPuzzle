using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gun : MonoBehaviour
{
	[SerializeField] private float force;
	[SerializeField] private Transform projectile;
	[SerializeField] private GameObject muzzle;
	public float fireRate = 15f;
	private float nextTimeToFire = 0f;


	private AudioManager audioManager;

	public int Magazine { get { return magazine; } set { magazine = value; } }
	private int magazine;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
		{
			Shoot();
			EmptyMagazine();
		}
    }

	private void EmptyMagazine()
	{
		Debug.Log(magazine);
		if (magazine == 0)
		{
			audioManager.PlayAudioOnce(3);
		}
	}

	private void Shoot()
	{
		if(magazine > 0)
		{
			magazine--;

			Transform clone;
			clone = Instantiate(projectile, muzzle.transform.position, muzzle.transform.rotation);
			clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * force);
			audioManager.PlayAudioOnce(0);
		}		
	}
}
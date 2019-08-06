using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gun : MonoBehaviour
{
	public static Action<int> AmmoEvent;

	[SerializeField] private float force;
	[SerializeField] private Transform projectile;
	[SerializeField] private GameObject muzzle;
	public float fireRate = 15f;
	private float nextTimeToFire = 0f;

	public int Magazine { get { return magazine; } set { value = magazine; } }
	private int magazine = 5;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && magazine > 0)
		{
			Shoot();
			magazine--;
			if(AmmoEvent != null)
			{
				AmmoEvent(magazine);
			}
		}
    }

	private void EmptyMagazine()
	{
		if(magazine == 0)
		{
			//Game Over
		}
	}


	private void Shoot()
	{
		Transform clone;
		clone = Instantiate(projectile, muzzle.transform.position, muzzle.transform.rotation);

		// Add force to the cloned object in the object's forward direction
		clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * force);
	}
}
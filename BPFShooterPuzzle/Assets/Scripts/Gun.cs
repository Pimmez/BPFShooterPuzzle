using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	[SerializeField] private float force;
	[SerializeField] private Transform projectile;
	public float fireRate = 15f;
	private float nextTimeToFire = 0f;
	[SerializeField] private GameObject muzzle;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
		{
			nextTimeToFire = Time.time + 1f / fireRate;
			Shoot();
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

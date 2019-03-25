﻿using UnityEngine;

public class Shoot : MonoBehaviour
{

	public float damage = 10f;
	public float range = 100f;

	public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0))
		{
			ShootBullet();
		}
    }

	private void ShootBullet()
	{
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
		}
		
	}
}

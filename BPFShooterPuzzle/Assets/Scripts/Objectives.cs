using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
	[SerializeField] private Color col;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tags.Projectile)
		{
			Debug.Log("DONE");
			gameObject.GetComponent<Renderer>().material.color = col;
		}
	}
}
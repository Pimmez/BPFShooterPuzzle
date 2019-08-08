using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	[SerializeField] private GameObject player;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tags.Player)
		{
			player.transform.parent = transform;
		}
	}


	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.tag == Tags.Player)
		{
			player.transform.parent = null;
		}
	}
}

using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
	public static Action CoinEvent;

	private float coinAmount = 10f;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == Tags.Player)
		{
			Destroy(this.gameObject);

			if (CoinEvent != null)
			{
				CoinEvent();
			}
		}
	}
}

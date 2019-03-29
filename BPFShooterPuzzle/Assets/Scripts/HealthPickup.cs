using System;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
	public static Action HealingEvent;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tags.Player)
		{
			Destroy(this.gameObject);

			if(HealingEvent != null)
			{
				HealingEvent();
			}
		}
	}
}
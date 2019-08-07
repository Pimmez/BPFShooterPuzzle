using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProps : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		Destroy(other);
		Debug.Log(other.name);
	}
}

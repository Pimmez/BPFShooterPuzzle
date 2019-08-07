using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerOptions : MonoBehaviour
{
	[SerializeField] private Gun gun;
	[SerializeField] private int magazineAmount;

    private void Start()
    {
		gun = FindObjectOfType<Gun>();
		gun.Magazine = magazineAmount;
	}
}
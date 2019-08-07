using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopHolder : MonoBehaviour
{
	public Animator anim;
	public List<GameObject> hoops = new List<GameObject>();

	private void Start()
	{
		anim = FindObjectOfType<Animator>();
	}

	private void Update()
	{
		if (hoops.Count == 0)
		{
			anim.SetBool("isCompleted", true);
		}
	}
}

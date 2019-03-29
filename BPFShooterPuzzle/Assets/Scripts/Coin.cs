using UnityEngine;

public class Coin : MonoBehaviour
{
	[SerializeField] private int coinAmount = 10;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tags.Player)
		{
			Destroy(this.gameObject);
			
			//Do Something
		}
	}
}

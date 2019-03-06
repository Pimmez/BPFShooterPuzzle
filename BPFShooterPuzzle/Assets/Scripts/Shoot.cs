using UnityEngine;

public class Shoot : MonoBehaviour
{

	private GameObject prefab;

	[SerializeField] private GameObject muzzle;
	[SerializeField] private float shootPower = 100;

	// Start is called before the first frame update
	void Start()
    {
		prefab = Resources.Load("Projectile") as GameObject;
    }

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
		Transform projectile = Instantiate(prefab, muzzle, Quaternion.identity) as Transform;
		Rigidbody rb = projectile.GetComponent<Rigidbody>();
		projectile.transform.parent = null;
		rb.velocity = muzzle.transform.forward * (shootPower * 10) * Time.deltaTime;
	}
}

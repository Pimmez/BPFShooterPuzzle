using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public float Health { get { return health; } }

	private float health = 1f;
	private float maxHealth = 1f;
	private float healingAmount = 0.15f;

	[SerializeField] private SceneManagement sceneManagement;

	//TEMP: DAMAGE GOES TO ENEMY WHEN DONE
	private float damage = 0.1f;

    // Start is called before the first frame update
    private void Start()
    {
		health = maxHealth;
    }

	private void Update()
	{
		CheckHealth();
	}

	private void CheckHealth()
	{
		if(health <= 0)
		{
			sceneManagement.SceneLoader("EndScreen");
		}
		if(health >= maxHealth)
		{
			health = maxHealth;
		}
	}

	private void Healing()
	{
		health += healingAmount;
	}

	private void OnEnable()
	{
		HealthPickup.HealingEvent += Healing;
	}

	private void OnDisable()
	{
		HealthPickup.HealingEvent -= Healing;
	}
}
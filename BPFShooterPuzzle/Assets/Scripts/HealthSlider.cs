using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
	private Image healthImage;
	private float threshold = 0.3f;
	[SerializeField] private PlayerHealth playerHealth;

	private Color flashColor = Color.white;

	private void Start()
	{
		healthImage = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update()
    {
		healthImage.fillAmount = playerHealth.Health;

		if(healthImage.fillAmount <= threshold)
		{
			healthImage.color = Color.red;
		}
	}
}

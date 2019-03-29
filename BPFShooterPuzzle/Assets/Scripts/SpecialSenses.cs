using UnityEngine;
using UnityEngine.PostProcessing;

public class SpecialSenses : MonoBehaviour
{
	private float saturationValue;
	private float maxSaturationValue = 1f;
	[SerializeField] private PostProcessingProfile ppProfile;

	[SerializeField] private PlayerHealth health;

	private void Start()
	{
		saturationValue = maxSaturationValue;
	}

	// Start is called before the first frame update
	void Update()
	{
		GrayScaleAtRuntime();
	}

	void GrayScaleAtRuntime()
	{
		{
			saturationValue = health.Health;

			//copy current ColorGrading settings from the profile into a temporary variable
			ColorGradingModel.Settings colorSettings = ppProfile.colorGrading.settings;

			//change the intensity in the temporary settings variable
			colorSettings.basic.saturation = saturationValue;

			//set the ColorGrading settings in the actual profile to the temp settings with the changed value
			ppProfile.colorGrading.settings = colorSettings;
		}
	}
}
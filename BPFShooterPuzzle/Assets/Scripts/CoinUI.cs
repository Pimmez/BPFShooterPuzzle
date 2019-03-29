using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
	private int coinsCollected;

	[SerializeField] private Text coinText;

	private void Start()
	{
		coinsCollected = 0;
	}

	private void Update()
	{
		coinText.text = "Collected: " + coinsCollected;
	}

	private void UpdateCoinScore()
	{
		coinsCollected++;
	}

	private void OnEnable()
	{
		Coin.CoinEvent += UpdateCoinScore;
	}

	private void OnDisable()
	{
		Coin.CoinEvent += UpdateCoinScore;
	}
}
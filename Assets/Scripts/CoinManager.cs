using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    [Header("Настройки монет")]
    public int totalCoins = 10;
    private int collectedCoins = 0;

    [Header("UI")]
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoin()
    {
        collectedCoins++;
        if (collectedCoins > totalCoins)
            collectedCoins = totalCoins;

        UpdateCoinUI();
    }

    private void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = $"Монеты: {collectedCoins} / {totalCoins}";
        }
    }
}
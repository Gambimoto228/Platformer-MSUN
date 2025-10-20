using UnityEngine;

public class CoinGlowEffectManager : MonoBehaviour
{
    public GameObject particlePrefab;

    void Start()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        foreach (GameObject coin in coins)
        {
            if (coin.GetComponentInChildren<ParticleSystem>() == null)
            {
                GameObject particleEffect = Instantiate(particlePrefab, coin.transform.position, Quaternion.identity);
                particleEffect.transform.SetParent(coin.transform);
            }
        }
    }
}

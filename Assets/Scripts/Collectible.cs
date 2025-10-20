using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private GameObject collectParticlePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (CoinManager.Instance != null)
            {
                CoinManager.Instance.AddCoin();
            }

            if (collectParticlePrefab != null)
            {
                Instantiate(collectParticlePrefab, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}
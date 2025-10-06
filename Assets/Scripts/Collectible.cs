using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� � ������� ����� ������ � ����� "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("����� ������ ������!");

            // ���������� �������� �����
            if (CoinManager.Instance != null)
            {
                CoinManager.Instance.AddCoin();
            }

            // ���������� ������ ������
            Destroy(gameObject);
        }
    }
}
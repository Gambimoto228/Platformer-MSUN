using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер вошёл объект с тегом "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок собрал монету!");

            // Уведомляем менеджер монет
            if (CoinManager.Instance != null)
            {
                CoinManager.Instance.AddCoin();
            }

            // Уничтожаем объект монеты
            Destroy(gameObject);
        }
    }
}
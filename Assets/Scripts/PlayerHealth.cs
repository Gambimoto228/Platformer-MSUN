using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Настройки здоровья")]
    public int maxHealth = 3;           // Максимальное количество жизней
    private int currentHealth;          // Текущее количество жизней

    [Header("UI")]
    public TextMeshProUGUI healthText;  // Ссылка на TMP-текст с сердечками

    [Header("Позиция возрождения")]
    public Vector3 respawnPoint;        // Место, куда возвращать игрока после падения

    void Start()
    {
        currentHealth = maxHealth;
        respawnPoint = transform.position; // Сохраняем стартовую позицию
        UpdateHealthUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
            currentHealth = 0;

        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Debug.Log("Игрок погиб. Перезапуск уровня...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            // Возвращаем игрока на стартовую позицию
            transform.position = respawnPoint;
        }
    }

    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = new string('♥', currentHealth);
        }
    }
}
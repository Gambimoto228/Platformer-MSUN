using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    [Header("Настройка")]
    [Tooltip("Тег объекта, при столкновении с которым будет перезапуск уровня")]
    public string playerTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, столкнулся ли куб с игроком
        if (collision.gameObject.CompareTag(playerTag))
        {
            Debug.Log("Столкновение с кубом — перезапуск уровня!");
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
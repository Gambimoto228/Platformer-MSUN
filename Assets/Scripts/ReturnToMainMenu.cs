using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    [Header("Название сцены главного меню")]
    public string mainMenuSceneName = "SettingsScene"; // Замените на точное имя вашей сцены

    void Update()
    {
        // Проверяем, нажата ли клавиша Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        // Загружаем сцену главного меню
        SceneManager.LoadScene(mainMenuSceneName);
    }
}

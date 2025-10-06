using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    [Header("�������� ����� �������� ����")]
    public string mainMenuSceneName = "SettingsScene"; // �������� �� ������ ��� ����� �����

    void Update()
    {
        // ���������, ������ �� ������� Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        // ��������� ����� �������� ����
        SceneManager.LoadScene(mainMenuSceneName);
    }
}

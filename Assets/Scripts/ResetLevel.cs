using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    [Header("���������")]
    [Tooltip("��� �������, ��� ������������ � ������� ����� ���������� ������")]
    public string playerTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        // ���������, ���������� �� ��� � �������
        if (collision.gameObject.CompareTag(playerTag))
        {
            Debug.Log("������������ � ����� � ���������� ������!");
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
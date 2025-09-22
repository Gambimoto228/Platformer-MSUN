using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("����� ����� � ���� ������!");

            // ������� 2: ������������� ������� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
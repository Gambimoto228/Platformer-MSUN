using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Этот метод можно вызвать через OnClick Events
    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel"); // SampleScene - это название файла сцены, которая откроется
    }
}
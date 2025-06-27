using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // Game sahnesinin adı bu olmalı
    }

    public void ExitGame()
    {
        UnityEngine.Debug.Log("Oyun kapatıldı"); // Build dışında çalışmaz
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinSceneManager : MonoBehaviour
{
    public TMP_Text lastScoreText;

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
        lastScoreText.text = $"Son Skor: {lastScore}";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

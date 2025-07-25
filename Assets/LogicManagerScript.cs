using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public float playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

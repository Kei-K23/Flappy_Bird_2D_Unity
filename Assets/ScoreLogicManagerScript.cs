using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogicManagerScript : MonoBehaviour
{
    public float playerScore;
    public TMP_Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}

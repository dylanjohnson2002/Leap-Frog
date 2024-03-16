using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure to include this for TextMeshPro

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    public TextMeshProUGUI winningMessageText; // Reference to the winning message text element

    private int player1Score = 0;
    private int player2Score = 0;

    public void IncrementScore(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1ScoreText.text = "Player 1: " + player1Score;
        }
        else if (playerNumber == 2)
        {
            player2Score++;
            player2ScoreText.text = "Player 2: " + player2Score;
        }

        CheckForWinner(); // Check for a winner after updating the score
    }

    private void CheckForWinner()
    {
        if (player1Score >= 4)
        {
            winningMessageText.text = "Player 1 Wins!";
            winningMessageText.color = new Color(winningMessageText.color.r, winningMessageText.color.g, winningMessageText.color.b, 1); // Set alpha to 1 to make it visible
        }
        else if (player2Score >= 4)
        {
            winningMessageText.text = "Player 2 Wins!";
            winningMessageText.color = new Color(winningMessageText.color.r, winningMessageText.color.g, winningMessageText.color.b, 1); // Set alpha to 1 to make it visible
        }
    }
}

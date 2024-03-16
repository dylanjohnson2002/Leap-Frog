using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public string opponentTag; // The tag of the opponent player
    private float triggerCooldown = 0.5f; // Cooldown time in seconds to prevent double scoring
    private float lastTriggerTime = -1f; // Time since the last trigger

    // Reference to the UIManager script
    private UIManager uiManager;

    void Start()
    {
        // Find the UIManager in the scene and get the UIManager component
        uiManager = GameObject.FindObjectOfType<UIManager>();
        if (uiManager == null)
        {
            Debug.LogError("UIManager not found in the scene.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has the opponent's tag and cooldown has passed
        if (other.CompareTag(opponentTag) && Time.time - lastTriggerTime > triggerCooldown)
        {
            // Update the time of the last trigger
            lastTriggerTime = Time.time;

            // Increment the score for Player 1 if the opponent was Player 2, and vice versa
            if (opponentTag == "Player2" && uiManager != null)
            {
                uiManager.IncrementScore(1); // Increment score for Player 1
            }
            else if (opponentTag == "Player1" && uiManager != null)
            {
                uiManager.IncrementScore(2); // Increment score for Player 2
            }
        }
    }
}

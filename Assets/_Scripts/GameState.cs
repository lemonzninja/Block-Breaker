using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    // Config params
    [Range(0.1f, 10f)] [SerializeField] private float gameSpeed = 1f;
    [SerializeField] private int pointsPerBlockDestroyed = 83;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    [SerializeField] private int currentScore = 0; // Serialized for Debug.
    
    private void Awake()
    {
        KeepGameStateToNextLvl();
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    private void Update()
    {
        Time.timeScale = gameSpeed;  // To Change the Speed of the game!
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;  // Add to the Current Score.
        scoreText.text = currentScore.ToString(); // Put the Current Score on the screen.
    }

    void KeepGameStateToNextLvl()
    {
        /*
         *  Keep the GameState gameObject to next Scene.
         * 
         *  -Find out how many GameStates are in the Scene.
         *  -keep only one GameState in the Scene.
         *  -Dont destroy the GameState in the next Scene.
         */
        
        int gameState = FindObjectsOfType<GameState>().Length; // Get the number of GameStates in the Scene
        
        if (gameState > 1) // Keep only one GameState game object.
        {
            Destroy(gameObject);
        }
        else // Dont Destroy the game object when we lode a new scene
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
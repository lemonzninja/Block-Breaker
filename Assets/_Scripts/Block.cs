using System;
using UnityEngine;

public class Block : MonoBehaviour
{   
    
    [SerializeField] private AudioClip breakSound; // The break Audio clip
    
    private Level _level;          // The reference to the level Script.
    private GameState _gameState; // The reference to the Game State Script

    private void Start()
    {
        // Pre Cached Reference's.
        _level = FindObjectOfType<Level>();
        _level.CountBreakableBlocks();
        _gameState = FindObjectOfType<GameState>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        /*
         * -Minus the number of breakableBlock in _level.
         *  -Play a AudioSource of the block brake when the ball hits it.
         *  -Destroy the block when the ball hits it.
         *  -Add points to the player score.
         */
        _gameState.AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, new Vector3(0,0,0));
        Destroy(gameObject);
        _level.BlockDestroyed();
    }
}
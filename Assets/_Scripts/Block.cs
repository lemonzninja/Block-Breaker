using System;
using UnityEngine;

public class Block : MonoBehaviour
{   
    // The break Audio clip
    [SerializeField] private AudioClip breakSound;
    
    // The reference to the level Script
    private Level _level;

    private void Start()
    {
        _level = FindObjectOfType<Level>();
        _level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        /*
         *  -Play a AudioSource of the block brake when the ball hits it.
         *  -Destroy the block when the ball hits it.
         */
        AudioSource.PlayClipAtPoint(breakSound, new Vector3(0,0,0));
        Destroy(gameObject);
        _level.BlockDestroyed();
    }
}
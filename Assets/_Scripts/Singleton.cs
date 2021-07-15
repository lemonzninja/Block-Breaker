using UnityEngine;

public class Singleton : MonoBehaviour
{
    private void Awake()
    {
        /*
        *  Keep the GameState gameObject to next Scene.
        * 
        *  -Find out how many GameStates are in the Scene.
        *  -keep only one GameState in the Scene.
        *  -Dont destroy the GameState when we go to the next Scene.
        */

        int gameState = FindObjectsOfType<GameState>().Length; // Get the number of GameStates in the Scene

        if (gameState > 1) // Keep only one GameState game object.
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else // Dont Destroy the game object when we lode a new scene
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{   
    public int currentSceneIndex;
    
    public void LoadNextScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        
        
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

    public void GameOverState()
    {
        SceneManager.LoadScene(3);
        
        FindObjectOfType<GameState>().ResetGame();
    }
}
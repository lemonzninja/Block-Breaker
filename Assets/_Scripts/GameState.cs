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
    
    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    private void Update()
    {
        Time.timeScale = gameSpeed; // To Change the Speed of the game!
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed; // Add to the Current Score.
        scoreText.text = currentScore.ToString(); // Put the Current Score on the screen.
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
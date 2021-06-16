using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] float screenWidthInUnits = 21f;
    [SerializeField] float minX = 1f;
    [SerializeField] float MaxX = 20.3f;
    
    void Update()
    {
        // Store the mouse position in a float
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        // A vector 2 to store the paddle position
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        // The paddle pos. Limited to the min max of the game
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, MaxX);
        // move the paddle
        transform.position = paddlePos;
    }
}
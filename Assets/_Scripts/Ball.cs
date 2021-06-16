using UnityEngine;

public class Ball : MonoBehaviour
{
   // Store the paddle game object
   [SerializeField] private Paddle _paddle;
   // The off set the ball from the center of the paddle 
   [SerializeField] private float ballYPos;
   // The x velocity of the ball on launce
   [SerializeField] private float xPush = 2f;
   // The y velocity of the ball on launce
   [SerializeField] private float yPush = 15f;
   
   // bool to start the game after the left mouse button was pushed
   private bool hasStarted = false;
   private void Update()
   {
      UnlockBallAndLaunce();
   }

   private void UnlockBallAndLaunce()
   {
      /*
       * - Keep the ball stuck on the paddle until
       * the left mouse button is pushed.
       * - launce the ball in the air when the left mouse button is pushed.
       */
      if (!hasStarted)
      {
         LockBallToPaddle();
         LaunchOnMouseClick();   
      }
   }

   private void LaunchOnMouseClick()
   {
      /* 
       * - Add a velocity to the ball when the left mouse button is pushed.
       * - Set the hasStarted to true. 
       */ 
      if (Input.GetMouseButton(0))
      {
         hasStarted = true;
         // Get the rigidbody2d of the ball
         GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
      }
   }

   private void LockBallToPaddle()
   {
      // The transform of the ball. Set to the transform position of the paddle plus the Y position we want the ball
      transform.position = new Vector2(_paddle.transform.position.x, _paddle.transform.position.y + ballYPos);
   }
}
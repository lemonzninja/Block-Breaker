using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
     [SerializeField] private int breakableBlock; // Serialized for debugging purposes

     private SceneLoader _sceneLoader;

     private void Start()
     {
          _sceneLoader = FindObjectOfType<SceneLoader>();
     }

     public void CountBreakableBlocks()
     {
          breakableBlock++;
     }

     public void BlockDestroyed()
     {
          breakableBlock--;
          if (breakableBlock <= 0)
          {
               _sceneLoader.LoadNextScene();
          }

          if (_sceneLoader.currentSceneIndex == 2)
          {
               _sceneLoader.GameOverState();
          }
     }
}

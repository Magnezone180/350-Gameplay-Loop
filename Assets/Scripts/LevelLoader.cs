using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
     // The name of the scene you want to load
    

    private void OnTriggerEnter(Collider other)
    {
            // Load the specified level
            SceneManager.LoadScene(2);
        
    }
}

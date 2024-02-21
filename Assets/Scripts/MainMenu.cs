using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    public void QuitGame()
    {
        if (Input.GetButtonDown("XRI_Left_Trigger"))
        {
            Application.Quit();
        }

        
    }
    
    public void StartGame()
    {
        Debug.Log("StartGame");
        
       SceneManager.LoadScene(1); 
    }
}

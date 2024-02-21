using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Permissions;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using System.Numerics;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public Transform head;
    public float spawnDistance = 2;
    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
      pauseMenuUI.SetActive(false);
      Time.timeScale =  1f;
      GameIsPaused = false;  
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("XRI_Left_MenuButton"))
       {
        if (GameIsPaused)
        {
            Resume();
        } else
        {
            Pause();
        }
       }
    }
    public void Resume ()
    {
      pauseMenuUI.SetActive(false);
      Time.timeScale =  1f;
      GameIsPaused = false;

    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        //pauseMenuUI.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
    }
    public void QuitGame()
    {
       
            Application.Quit();
        
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // public GameObject mainCamera;
    // Vector3 cameraPosition;
    // Update is called once per frame
    void Start() {
        //mainCamera = GameObject.Find("Main Camera");
        //cameraPosition = mainCamera.GetComponent<Transform>().position;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
        
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("MainMenuScene");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void RestartLevel(){
        //mainCamera.GetComponent<Transform>().position = cameraPosition;
        //SceneManager.UnloadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }


}

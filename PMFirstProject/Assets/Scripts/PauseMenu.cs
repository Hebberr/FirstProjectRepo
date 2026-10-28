using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (GetComponent<Canvas>().enabled == true)
            {
                ResumeGame();
            }
            else if (GetComponent<Canvas>().enabled == false)
            {
                PauseGame();
            }
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            ReloadLevel();
        }
        if (Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            LoadMainMenu();
        }
    }

    //create two functions
    //pause and resume.
    //PAUSE: stop the game, open the pause menu
    public void PauseGame()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    //RESUME: start the game, close the pause menu
    public void ResumeGame()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

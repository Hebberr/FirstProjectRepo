using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            PlayGame();
        }
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            QuitGame();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("TestLevel");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitGame()
    {

    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

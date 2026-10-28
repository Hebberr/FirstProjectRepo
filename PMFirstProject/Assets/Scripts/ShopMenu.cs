using UnityEngine;
using UnityEngine.InputSystem;


public class ShopMenu : MonoBehaviour
{
    public GameObject Player;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject ShopManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
        Item1.GetComponent<SpriteRenderer>().enabled = false;
        Item2.GetComponent<SpriteRenderer>().enabled = false;
        Item3.GetComponent<SpriteRenderer>().enabled = false;
        Item4.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            if (GetComponent<Canvas>().enabled == true)
            {
                CloseShop();
            }
            else if (GetComponent<Canvas>().enabled == false)
            {
                OpenShop();
            }
        }
    }
    public void OpenShop()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
        Item1.GetComponent<SpriteRenderer>().enabled = true;
        Item2.GetComponent<SpriteRenderer>().enabled = true;
        Item3.GetComponent<SpriteRenderer>().enabled = true;
        Item4.GetComponent<SpriteRenderer>().enabled = true;

    }
    //RESUME: start the game, close the pause menu
    public void CloseShop()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
        Item1.GetComponent<SpriteRenderer>().enabled = false;
        Item2.GetComponent<SpriteRenderer>().enabled = false;
        Item3.GetComponent<SpriteRenderer>().enabled = false;
        Item4.GetComponent<SpriteRenderer>().enabled = false;
    }
}

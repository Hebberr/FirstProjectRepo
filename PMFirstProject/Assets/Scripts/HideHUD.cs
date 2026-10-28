using UnityEngine;
using UnityEngine.InputSystem;

public class HideHUD : MonoBehaviour
{
    public GameObject ShopCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            if (ShopCanvas.GetComponent<Canvas>().enabled == false)
            {
                GetComponent<Canvas>().enabled = false;
            }
            else
            {
                GetComponent<Canvas>().enabled = true;
            }
        }
    }
}

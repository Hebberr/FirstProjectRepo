using UnityEngine;
using UnityEngine.InputSystem;

public class HideShopSprites : MonoBehaviour
{
    public GameObject ShopCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            if (ShopCanvas.GetComponent<Canvas>().enabled == true)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
}

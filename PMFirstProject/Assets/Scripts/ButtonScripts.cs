using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonScripts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int ItemID;
    private void Start()
    {
        ItemID = Random.Range(1, 5);
    }
    public TMP_Text PriceTxt;
    public TMP_Text QuantityTxt;
    public GameObject ShopManager;
    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = "Price: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = "Owned:" + ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public GameObject Player;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public TMP_Text CoinsTXT;
    public int Item1Price = 3;
    public int Item2Price = 4;
    public int Item3Price = 5;
    public int Item4Price = 6;
    void Start()
    {
        CoinsTXT.text = "Coins: " + Player.GetComponent<CoinCollection>().coins;
        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        //Price
        shopItems[2, 1] = Item1Price;
        shopItems[2, 2] = Item2Price;
        shopItems[2, 3] = Item3Price;
        shopItems[2, 4] = Item4Price;
        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
    }
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(Player.GetComponent<CoinCollection>().coins >= shopItems[2, ButtonRef.GetComponent<ButtonScripts>().ItemID])
        {
            Player.GetComponent<CoinCollection>().coins -= shopItems[2, ButtonRef.GetComponent<ButtonScripts>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonScripts>().ItemID]++;
            ButtonRef.GetComponent<ButtonScripts>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonScripts>().ItemID].ToString();
            CoinsTXT.text = "Coins: " + Player.GetComponent<CoinCollection>().coins;
            if (shopItems[1, ButtonRef.GetComponent<ButtonScripts>().ItemID] == 1)
            {
                GameObject ItemOne = Instantiate(Item1, Player.transform.position, Quaternion.identity);
                ItemOne.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
            else if (shopItems[1, ButtonRef.GetComponent<ButtonScripts>().ItemID] == 2)
            {
                GameObject ItemTwo = Instantiate(Item2, Player.transform.position, Quaternion.identity);
                ItemTwo.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
            else if (shopItems[1, ButtonRef.GetComponent<ButtonScripts>().ItemID] == 3)
            {
                GameObject ItemThree = Instantiate(Item3, Player.transform.position, Quaternion.identity);
                ItemThree.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
            else if (shopItems[1, ButtonRef.GetComponent<ButtonScripts>().ItemID] == 4)
            {
                GameObject ItemFour = Instantiate(Item4, Player.transform.position, Quaternion.identity);
                ItemFour.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }

    void Update()
    {
        CoinsTXT.text = "Coins: " + Player.GetComponent<CoinCollection>().coins;
    }
}

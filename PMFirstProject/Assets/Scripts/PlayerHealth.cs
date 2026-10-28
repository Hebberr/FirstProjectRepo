using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    //store hp in a variable
    public int health = 10;
    public string pName = "Heb";
    //the text object I want to updae to display my current health
    public TMP_Text healthText;
    void Start()
    {
        healthText.text = "Health: " + health;
    }
    //if we hit an enemy, reduce hp
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(pName + " hit " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            //update health text to match new hp value
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health--;
            //update health text to match new hp value
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "Boss")
        {
            health -= 3;
            //update health text to match new hp value
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "hpPack" && health < 10)
        {
            health++;
            healthText.text = "Health: " + health;
            Destroy(collision.gameObject);
        }
        //when we lose all of our hp, we die
        //when we die, reload the current level
        if (health < 1)
        {
            Debug.Log(name + " was ripped apart by " + collision.gameObject.name);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(pName + " hit " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            //update health text to match new hp value
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health--;
            //update health text to match new hp value
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "Boss")
        {
            health -= 3;
            //update health text to match new hp value
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "hpPack" && health < 10)
        {
            health++;
            healthText.text = "Health: " + health;
            Destroy(collision.gameObject);
        }
        //when we lose all of our hp, we die
        //when we die, reload the current level
        if (health < 1)
        {
            Debug.Log(name + " was ripped apart by " + collision.gameObject.name);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }




}

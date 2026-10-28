using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float eHealth = 10;
    public float maxHealth = 10;
    public GameObject hpPack;
    public GameObject valuable;
    public GameObject veryValuable;
    public GameObject legendaryValue;
    public GameObject ammoPack;
    public float randRotate = 0;
    public Image healthFillImage;
    private void Start()
    {
        eHealth = maxHealth;
        UpdateHealthBar();
    }

    public void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            eHealth--;
            UpdateHealthBar();
        }
        if (eHealth < 1)
        {
            if (gameObject.tag == "Boss")
            {
                SceneManager.LoadScene("VictoryScene");
            }
            float rand = Random.Range(1, 99);
            if (rand < 100 / 3)
            {
                randRotate = Random.Range(0, 360);
                Debug.Log(name + " dropped an ammo pack.");
                GameObject ammoDrop = Instantiate(ammoPack, transform.position, Quaternion.identity);
                ammoDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                ammoDrop.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
            }
            rand = Random.Range(1, 99);
            if (rand < 25)
            {
                randRotate = Random.Range(0, 360);
                Debug.Log(name + " dropped a health pack.");
                GameObject hpDrop = Instantiate(hpPack, transform.position, Quaternion.identity);
                hpDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                hpDrop.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
            }
            rand = Random.Range(1, 99);
            if (rand < 100)
            {
                int vAmount = Random.Range(2, 7);
                Debug.Log(name + " dropped valuables.");
                for (int i = 0; i < vAmount; i++)
                {
                    randRotate = Random.Range(0, 360);
                    GameObject val = Instantiate(valuable, transform.position, Quaternion.identity);
                    val.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    val.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
                }
            }
            rand = Random.Range(1, 99);
            if (rand < 25)
            {
                int vAmount = Random.Range(1, 4);
                Debug.Log(name + " dropped something very valuable!");
                for (int i = 0; i < vAmount; i++)
                {
                    randRotate = Random.Range(0, 360);
                    GameObject vValuable = Instantiate(veryValuable, transform.position, Quaternion.identity);
                    vValuable.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    vValuable.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
                }
            }
            rand = Random.Range(1, 99);
            if (rand < 5)
            {
                int vAmount = Random.Range(1, 2);
                Debug.Log(name + " dropped legendary treasure!!!");
                for (int i = 0; i < vAmount; i++)
                {
                    randRotate = Random.Range(0, 360);
                    GameObject legendaryTreasure = Instantiate(legendaryValue, transform.position, Quaternion.identity);
                    legendaryTreasure.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    legendaryTreasure.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
                }
            }
            Debug.Log(gameObject.name + " Died");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            eHealth--;
            UpdateHealthBar();
        }
        if(eHealth < 1)
        {
            if(gameObject.tag == "Boss")
            {
                SceneManager.LoadScene("VictoryScene");
            }
            float rand = Random.Range(1, 99);
            if (rand < 100 / 3)
            {
                randRotate = Random.Range(0, 360);
                Debug.Log(name + " dropped an ammo pack.");
                GameObject ammoDrop = Instantiate(ammoPack, transform.position, Quaternion.identity);
                ammoDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                ammoDrop.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
            }
            rand = Random.Range(1, 99);
            if (rand < 25)
            {
                randRotate = Random.Range(0, 360);
                Debug.Log(name + " dropped a health pack.");
                GameObject hpDrop = Instantiate(hpPack, transform.position, Quaternion.identity);
                hpDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                hpDrop.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
            }
            rand = Random.Range(1, 99);
            if (rand < 100)
            {
                int vAmount = Random.Range(2, 7);
                Debug.Log(name + " dropped valuables.");
                for (int i = 0; i < vAmount; i++)
                {
                    randRotate = Random.Range(0, 360);
                    GameObject val = Instantiate(valuable, transform.position, Quaternion.identity);
                    val.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    val.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
                }
            }
            rand = Random.Range(1, 99);
            if (rand < 25)
            {
                int vAmount = Random.Range(1, 4);
                Debug.Log(name + " dropped something very valuable!");
                for (int i = 0; i < vAmount; i++)
                {
                    randRotate = Random.Range(0, 360);
                    GameObject vValuable = Instantiate(veryValuable, transform.position, Quaternion.identity);
                    vValuable.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    vValuable.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
                }
            }
            rand = Random.Range(1, 99);
            if (rand < 5)
            {
                int vAmount = Random.Range(1, 2);
                Debug.Log(name + " dropped legendary treasure!!!");
                for (int i = 0; i < vAmount; i++)
                {
                    randRotate = Random.Range(0, 360);
                    GameObject legendaryTreasure = Instantiate(legendaryValue, transform.position, Quaternion.identity);
                    legendaryTreasure.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    legendaryTreasure.GetComponent<Rigidbody2D>().angularVelocity += randRotate;
                }
            }
            Debug.Log(gameObject.name + " Died");
            Destroy(gameObject);
        }
    }
    void UpdateHealthBar()
    {
        Debug.Log(eHealth);
        Debug.Log(healthFillImage.fillAmount);
        healthFillImage.fillAmount = eHealth / maxHealth;

    }

}

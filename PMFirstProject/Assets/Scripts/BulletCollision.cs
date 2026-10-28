using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public GameObject Explosion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Bullet hit " + collision.gameObject.name);
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Valuable" && collision.gameObject.tag != "VeryValuable" && collision.gameObject.tag != "LegendaryValue" && collision.gameObject.tag != "hpPack" && collision.gameObject.tag != "AmmoPack" && collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "EnemyBullet")
        {
            GameObject Blast = Instantiate(Explosion, transform.position, Quaternion.identity);
            //Blast.GetComponent<Rigidbody2D>().linearVelocity = GetComponent<Rigidbody2D>().linearVelocity *= 0.01f;
            Destroy(Blast, 0.1f);
            Destroy(gameObject);
        }
    }
}

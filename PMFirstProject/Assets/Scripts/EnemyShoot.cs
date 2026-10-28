using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    //the bullet object that the enemy will shoot
    public GameObject bullet;
    public float bulletSpeed =  5;
    public float shootDelay = 3;
    public float enemyRange = 10;
    GameObject Player;

    //I need to know how much time has passed between shots
    float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //every x seconds, we want to shoot at the player if the player is close
        //delta time means the changes in time between frame updates
        //we are adding the slivers of time between frames, to figure out how much total time has passed
        timer += Time.deltaTime;
        Vector2 shootDir = Player.transform.position - transform.position;
        if (timer > shootDelay && shootDir.magnitude < enemyRange)
        {
            //shoot is off cooldown, try to shoot at the player
            shootDir.Normalize();
            timer = 0;
                GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
                Destroy(shot, 5);
                shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
        }

    }
}

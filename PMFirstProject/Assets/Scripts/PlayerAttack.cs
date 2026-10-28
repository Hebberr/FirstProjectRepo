using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public int pAmmo = 12;
    public TMP_Text ammoText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammoText.text = "Ammo: " + pAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float bulletSpeed = 10;
    //OnAttack will get called whenever the attack buttons are pressed
    //create a new copy of the player bullet object
    //push the bullet in the direction of the mouse
    //destroy the bullet after a few seconds to keep the level clean
    public GameObject bullet;
    public GameObject meleeAttack;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AmmoPack")
        {
            pAmmo += 6;
            ammoText.text = "Ammo: " + pAmmo;
            Destroy(collision.gameObject);
        }
    }
    public void OnAttack()
    {
        if (pAmmo > 0 && Time.timeScale == 1)
        {
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(shot, 5);
            //our equation for the shoot direction is Destination - Starting Position
            //Start at player, end at mouse
            //first we need to find where the mouse is on the screen
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            //Debug.Log(mousePos);
            Vector2 shootDir = mousePos - transform.position;
            //we fix the length of the shoot direction to always have a length of one
            shootDir.Normalize();
            //push bullet in shootDir direction. Like player movement
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
            pAmmo--;
            ammoText.text = "Ammo: " + pAmmo;
        }
        else
        {
            //GameObject swing = Instantiate(meleeAttack, transform.position, Quaternion.identity);
            //Destroy(swing, 0.1f); 
        }
    }
}

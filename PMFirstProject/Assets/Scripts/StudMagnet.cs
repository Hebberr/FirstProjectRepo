using Unity.VisualScripting;
using UnityEngine;

public class StudMagnet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 pullDir = player.transform.position - transform.position;
        GetComponent<Rigidbody2D>().linearVelocity = pullDir;
        //if (GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
        //{
            //Vector3 pullDir = player.transform.position - transform.position;
            //pullDir.Normalize();
            //GetComponent<Rigidbody2D>().linearVelocity = pullDir;
        //}

    }
}

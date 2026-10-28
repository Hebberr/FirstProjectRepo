using Unity.VisualScripting;
using UnityEngine;

public class AutoAim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public float closestEnemyDist;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FindNearestEnemyPos()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //An array is a collection of variables of one type, in this case, GameObjects
        for (int i = 0; i < enemies.Length; i++)
        {
            //length is the number of vaiables stored in the array
            //as long as the number of variables stored in the array,
            //this code will continue to run
            Debug.Log(enemies[i].transform.position);
        }
    }
}

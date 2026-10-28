using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //any time we are looping through something, it can be heavy in processing
        //"for loop" is teh most  common form of looping through repeated behavior
        //for example; loop through all enemies, shoot at the nearest one
        //anatomy of for loop: first has a starting variable, then it has a break condition, 
        //Finally it has an operation that happens each loop
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
        float Ans = 0;
        for (int i = 17; i < 193; i++)
        {
            Ans += i;
        }
        Debug.Log(Ans);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}

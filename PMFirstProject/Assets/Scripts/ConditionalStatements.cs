using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if statements check to see if a value is true or false
        //if the value is true, the contained code is run
        //if the valuse is false, the code is skipped
        if (true)
        {
            //This code will be run if the condition is true
            Debug.Log("this code is running!");
        }
        int health = 10;
        if(health > 0)
        {
            Debug.Log("I'm alive!!");
        }
        if (health < 1)
        {
            Debug.Log("I am dead.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

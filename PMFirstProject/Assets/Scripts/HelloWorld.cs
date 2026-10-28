using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This is a code comment
        //Debug is a class that someone else wrote
        //Debug has a function named Log
        Debug.Log("Hello World!");

        int health = 10;
        health = 9;
        health = 10 - 1;
        health = health - 1;
        float critChance = 0.1f;
        critChance = critChance + 0.1f;
        string name = "John";
        Debug.Log("Hello" + name);
        bool hasKey = true;
        bool isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

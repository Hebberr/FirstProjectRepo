using UnityEngine;

public class BoolConditions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (true)
        {
            //this code will always run
        }
        if (false)
        {
            //this code will never run
        }
        if (true && true)
        {
            //this code will run, because all are true
            //&& as an operation means that all conditions must be true to run
        }
        if (true && false)
        {
            //this code will not run, because at least one is false
        }
        if (false && false)
        {
            //this code will not run, because at least one is false
        }
        if (true || true)
        {
            //this code will run because at least one is true
        }
        if (false || true)
        {
            //this code will run because at least one is true
        }
        if (false || false)
        {
            //this code will not run because none are true
        }
        if (true && false || true && true && false || true && true && true || false)
        {
            //first break it down into each or section, see if its true or false
            //false || false || true || false
            //This code will run because at least one is true
        }
        if (false && true || false && false || true && false || true && true)
        {
            //false || false || false || true
            //This code will run because at least one is true
        }
        if(false || true && !false)
        {
            //! means not, !false = true
            //This code will run because at least one is true
        }
        bool isAlive = true;
        if(isAlive == true)
        {
            //Inneficient, do this instead
            if (isAlive)
            {

            }
        }
        bool hasCake = false;
        int eggs = 2;
        bool hasOil = true;
        bool hasBoxMix = true;
        bool hasMoney = false;
        if(hasCake || eggs > 1 && hasOil && hasBoxMix || hasMoney)
        {
            //Eat cake
        }
        else
        {
            //I eat a cookie
            //Runs only if the IF code is false
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

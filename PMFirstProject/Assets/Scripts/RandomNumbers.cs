using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int r = -1;
        r = Random.Range(1, 101);
        Debug.Log(r);

        float rand = Random.Range(1f, 100f);
        Debug.Log(rand);
        //If my random float is high enough, get a special loot drop
        if(rand > 50)
        {
            Debug.Log("Hooray, you got... The Raisin of Dissapointment...");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

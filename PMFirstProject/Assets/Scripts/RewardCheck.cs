using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class RewardCheck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        int score = 0;
        if (score < 100)
        {
            Debug.Log("Keep Playing!");
        }
        if (score > 99)
        {
            Debug.Log("Reward Unlocked!");
        }
    }
}

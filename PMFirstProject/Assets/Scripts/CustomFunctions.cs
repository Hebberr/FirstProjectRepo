using UnityEngine;

public class CustomFunctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //variables defined at the class level can be used elsewhere
    public string name = "Heb";
    public int xp = 100;
    public int level = 1;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }

    void LevelUp()
    {
        //when we level up, we increase player level if xp is high enough, then reduce xp
        //two variables we really care about: xp and level (maybe: xp cap, stats, etc)
        int reqXp = 10 + (level * 5);
        if (xp >= reqXp)
        {
            //when I level up, gain a level and subtract xp required to level from xp xp
            level++;
            xp -= reqXp;
            reqXp = 10 + (level * 5);
            Debug.Log(name + " has leveled up to level " + level);
            if (xp < reqXp)
            {
                Debug.Log(name + " has " + xp + " xp. " + (reqXp - xp) + " xp remaining till level up.");
            }
            
        }
    }
}

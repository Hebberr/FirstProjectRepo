using UnityEngine;

public class GrapeSwordofWrathUpgrade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string pName = "Heb";
    public int coins = 100;
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
        if (coins >= reqXp)
        {
            //when I level up, gain a level and subtract xp required to level from xp xp
            level++;
            coins -= reqXp;
            reqXp = 10 + (level * 5);
            Debug.Log(pName + " has upgraded The GrapeSword of Wrath to level " + level);
            if (coins < reqXp)
            {
                Debug.Log(pName + " has " + coins + " coins left. " + (reqXp - coins) + " more coins needed to upgrade The GrapeSword of Wrath.");
            }

        }
    }
}

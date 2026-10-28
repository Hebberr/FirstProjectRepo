using UnityEngine;

public class LootSim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string Name = "Heb";
        int Atk = Random.Range(1, 101);
        if (Atk > 50)
        {
            Debug.Log(Name + " defeated the Grapeus Maximus with a huge " + Atk + " Atk!");
            Debug.Log(Name + " found...");
            int Rand = Random.Range(1, 101);
            if (Rand > 90)
            {
                Debug.Log("The mighty Grapesword of Wrath!");
            }
            else if (Rand > 75)
            {
                Debug.Log("A delicious bunch of grapes.");
            }
            else if (Rand > 50)
            {
                Debug.Log("The Raisin of Disapointment...");
            }
            else
            {
                Debug.Log("Nothing...");
            }
        }
        else
        {
            Debug.Log(Name + " could not defeat Grapeus Maximus with a piteous " + Atk + " Atk. " + Name + " needs at least 51 Atk. " + Name + " died...");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALMALKEY : MonoBehaviour
{
    //hero stuff
    string heroName = "ALMALKEY";
    int heroPower = 25;

    //villain stuff
    string villainName = "7md";
    int villairPower = 25;

    float playerSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
         {
        if (heroPower > villairPower)
        {
            print(heroName + " is stronger");
        }
        else if (heroPower == villairPower)
        {
            print(heroName + " eqauls " + villainName);
        } else
        {
            print(villainName + " is stronger ");
        }

        SetSpeed(2.5f);
    }

        
    }
    void SetSpeed(float speed){

        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
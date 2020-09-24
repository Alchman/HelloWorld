using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerHealth; //объявили переменную с именем и типом
        //int enemyHealth;

        //enemyHealth = playerHealth + 10 / 2;
        //playerHealth = 50;

        //print(enemyHealth);

        //float damage = 4.5f;
        //playerHealth = (int) damage;

        //string playerName;
        //playerName = "Denis";

        //print("Hello " + playerName + ", your health: " + playerHealth);


        //playerHealth = 0;

        //bool isAlive;
        //isAlive = playerHealth > 0 && enemyHealth > 0;


        //isAlive = playerHealth > 0 || enemyHealth > 0;

        //print("is player alive: " + isAlive);

        //bool isAlive = false;
        playerHealth = -10;

        if (playerHealth > 0)
        {
            //true
            print("Player alive!");
        }
        else
        {
            //false
            print("Player not alive :(");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // print("Update");
    }
}

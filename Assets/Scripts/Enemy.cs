using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;
    int defense;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello, I'm " + name);
    }

    public void Attack(int damageParam)
    {
        health -= damageParam;
        print("Health left: " + health);
        if (health <= 0)
        {
            print(name + " I'm dead");
        }

    }

    public int GetHealth()
    {
        return health;
    }
}

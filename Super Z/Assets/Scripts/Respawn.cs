using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Vector3 startPosition;
    public int curHealth;
    public int maxHealth;
    void Start()
    {
        curHealth = maxHealth;
        startPosition = transform.position;
    }

    public void Damage(int dmg)
    {
        curHealth -= dmg;
        Reset();
    }


    void Reset()
    {
        transform.position = startPosition;
    }
}

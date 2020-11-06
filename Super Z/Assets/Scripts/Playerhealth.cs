using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
        public int curHealth;
        public int maxHealth = 3;

        void Start()
        {
            curHealth = maxHealth;
        }


        void Update()
        {
            if (curHealth > maxHealth)
            {
                curHealth = maxHealth;
            }
            if (curHealth <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        public void Damage(int dmg)
        {
        curHealth -= dmg;
        }
}

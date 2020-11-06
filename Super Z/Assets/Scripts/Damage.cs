using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
        private Playerhealth player;

        void Start()
        {

            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Playerhealth>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {

                player.Damage(1);

            }
        }
}

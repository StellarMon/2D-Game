using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Collectable : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter(Collider info)
    {
        if (info.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
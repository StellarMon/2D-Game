using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Unlocks : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Cape"))
            {
                GameObject.Find("Player").GetComponent<PlatformerCharacter2D>().unlockedDouble = true;
                Destroy(gameObject);
            }
        }
    }
}
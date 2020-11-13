using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    void Start ()
    {
        if(gm == null)
        {
            gm = this;
        }
        
    }

    public Transform playerPrefab;
    public Transform spawnPoint;

    public void RespawnPlayer()
    {
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
   public static void KillPlayer (Player player)
    {
        Destroy(player.gameObject);
        gm.RespawnPlayer();
    }
}

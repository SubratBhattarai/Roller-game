using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public PlayerMovement player;
    
    private void OnCollisionEnter(Collision collisionData)
    {
        if(collisionData.collider.tag == "Obstacle"){
            player.enabled = false;
            FindObjectOfType<Endgame>().Ending();
        }
    }
}

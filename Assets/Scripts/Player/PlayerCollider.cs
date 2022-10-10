using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour, ICollider
{
    [SerializeField] private PlayerMovement playerMovement;

    public void GetHit(string tag)
    {
        if(tag.Equals("Island"))
            playerMovement.Speed = 0f;

        if(tag.Equals("Sea"))
            playerMovement.Speed %= 2f;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetHit(collision.gameObject.tag);
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetHit(collision.tag);
    }
}

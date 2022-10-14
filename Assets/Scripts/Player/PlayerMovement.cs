using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the player movement
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Header ("Component References")]
    [SerializeField] private Rigidbody2D playerRB;

    [Header ("Script References")]
    [SerializeField] private ShipData shipData;
    
    private float speed;


    void Start()
    {
        speed = shipData.Speed;
    }

    void FixedUpdate()
    {

        
        playerRB.velocity = new Vector2 (Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed) ;

    }

    public float Speed { get { return speed; } set { speed = value; } }
}

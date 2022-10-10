using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private ShipData shipData;
    [SerializeField] private float speed;


    void Start()
    {
        speed = shipData.Speed;
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {

        
        playerRB.velocity = new Vector2 (Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed) ;

    }




    public float Speed { get { return speed; } set { speed = value; } }
}

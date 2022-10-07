using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private ShipData shipData;
    private float speed;

    void Start()
    {
        speed = shipData.Speed;
    }

    // Update is called once per frame
    void Update()
    {
        float movx = Input.GetAxis("Horizontal");
        float movy = Input.GetAxis("Vertical");

        playerRB.velocity = Vector2.right * movy * speed;

    }

    private void MoveForward()
    {
        
    }

 

    public float Speed { get { return speed; } set { speed = value; } }
}

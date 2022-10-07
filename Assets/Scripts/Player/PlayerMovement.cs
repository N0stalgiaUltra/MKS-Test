using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movx = Input.GetAxis("Horizontal");
        float movy = Input.GetAxis("Vertical");

        playerRB.velocity = new Vector2(movx * speed, movy * speed);
    }
    
    public float Speed { get { return speed; } set { speed = value; } }
}

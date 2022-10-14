using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the movement for the Chaser type of enemy. Inherits from Enemy Movement
/// </summary>
public class ChaserMovement : EnemyMovement
{
    [SerializeField] private ShipData shipData;
    private float speed;
    private void Awake()
    {
        speed = shipData.Speed;
    }
    private void Update()
    {
        Move(speed);
        Rotate();
    }
    
    public float Speed { get { return speed; } set { speed = value; } }

}

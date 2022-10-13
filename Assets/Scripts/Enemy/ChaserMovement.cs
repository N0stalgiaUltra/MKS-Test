using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

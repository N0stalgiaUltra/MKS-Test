using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserMovement : EnemyMovement
{
    [SerializeField] private ShipData shipData;

    void Update()
    {
        Move(shipData.Speed);
        Rotate();
    }
    

}

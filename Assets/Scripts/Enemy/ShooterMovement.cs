using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : EnemyMovement
{
    [SerializeField] private float maxDistance;
    [SerializeField] private ShipData shipData;


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, playerTransform.position) <= maxDistance)
            Shoot();
        else
        {
            Move(shipData.Speed);
        }

        Rotate();

    }

    private void Shoot()
    {
        Debug.Log("Shooting");
    }
}

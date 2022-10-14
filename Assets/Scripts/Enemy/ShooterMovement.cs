using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contols the movement of the Shooter Type of enemy, inherits from Enemy Movement
/// </summary>
public class ShooterMovement : EnemyMovement
{
    [Header ("Script References")]
    [SerializeField] private ShipData shipData;
    [SerializeField] private EnemyShoot enemyShoot;

    [Header ("Max Distance")]
    [SerializeField] private float maxDistance;

    private float speed;

    private void Awake()
    {
        speed = shipData.Speed;

    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, playerTransform.position) <= maxDistance)
            enemyShoot.Shoot();
        else
        {
            Move(speed);
        }

        Rotate();

    }
    public float Speed { get { return speed; } set { speed = value; } }


}

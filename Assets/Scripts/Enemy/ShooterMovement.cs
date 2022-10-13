using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : EnemyMovement
{
    [SerializeField] private float maxDistance;
    [SerializeField] private ShipData shipData;
    [SerializeField] private EnemyShoot enemyShoot;
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

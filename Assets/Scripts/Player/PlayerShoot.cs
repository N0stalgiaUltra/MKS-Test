using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private BulletPooling bulletPool;
    [SerializeField] private Transform frontalBulletSpawn;
    [SerializeField] private Transform[] lateralBulletSpawns = new Transform[3]; 
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            bulletPool.SingleBulletSpawn(frontalBulletSpawn, true);

        if (Input.GetMouseButtonDown(1))
            bulletPool.MultipleBulletSpawn(lateralBulletSpawns, true);

    }
}

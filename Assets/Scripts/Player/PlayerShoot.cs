using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private BulletPooling bulletPool;
    [SerializeField] private Transform bulletSpawn;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            bulletPool.SingleBulletSpawn(bulletSpawn, true);
    }
}

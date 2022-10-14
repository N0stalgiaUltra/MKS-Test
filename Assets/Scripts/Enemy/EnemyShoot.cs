using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the Shoot of the Shooter type of enemy
/// </summary>
public class EnemyShoot : MonoBehaviour
{
    private BulletPooling bulletPool;

    [Header("Bullet Spawn")]
    [SerializeField] private Transform bulletSpawn;

    [Header ("Fire Rate")]
    [SerializeField] private float fireRate;
    private float nextFire;
    private void Awake()
    {
        bulletPool = GameObject.FindGameObjectWithTag("BulletPool").GetComponent<BulletPooling>();
    }
    private void Update()
    {
        nextFire -= Time.deltaTime;
    }
    public void Shoot()
    {
        if(nextFire <= 0) 
        {
            bulletPool.SingleBulletSpawn(bulletSpawn, false);
            nextFire = fireRate;
        }
    }
}

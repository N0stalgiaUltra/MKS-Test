using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private BulletPooling bulletPool;
    [SerializeField] private Transform bulletSpawn;
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

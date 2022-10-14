using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls ths input and shooting of the player
/// </summary>
public class PlayerShoot : MonoBehaviour
{
    [Header("Script References")]
    [SerializeField] private BulletPooling bulletPool;

    [Header("Bullet Spawns")]
    [SerializeField] private Transform frontalBulletSpawn;
    [SerializeField] private Transform[] lateralBulletSpawns = new Transform[3];

    [Header("Fire Rates")]
    [SerializeField] private float singleShotFireRate;
    [SerializeField] private float tripleShotFireRate;

    private float nextSingleShot;
    private float nextTripleShot;

    private void Start()
    {
        nextSingleShot = singleShotFireRate;
        nextTripleShot = tripleShotFireRate; 
    }


    // Update is called once per frame
    void Update()
    {
        nextSingleShot -= Time.deltaTime;
        nextTripleShot -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
            SingleShot();

        if (Input.GetMouseButtonDown(1))
            MultipleShot();
    }

    private void SingleShot() 
    {
        if(nextSingleShot <= 0f)
        {
            bulletPool.SingleBulletSpawn(frontalBulletSpawn, true);
            nextSingleShot = singleShotFireRate;
        }
    }

    private void MultipleShot() 
    { 
        if(nextTripleShot <= 0f)
        {
            bulletPool.MultipleBulletSpawn(lateralBulletSpawns, true);
            nextTripleShot = tripleShotFireRate;
        }
    }
}

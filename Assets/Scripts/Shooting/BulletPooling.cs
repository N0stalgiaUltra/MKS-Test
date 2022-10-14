using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the Object Pool Pattern for instantiating bullets in the scene
/// </summary>
public class BulletPooling : MonoBehaviour
{
    [Header ("Script References")]
    [SerializeField] private BulletFactory bulletFactory;

    [Header("Queue Quantity")]
    [SerializeField] private int bulletsQuantity;
    [SerializeField] private Queue<BulletLogic> bulletQueue = new Queue<BulletLogic>();

    private const string PlayerLayer = "PlayerBullets";
    private const string EnemyLayer = "EnemyBullets";
    private const string DefaultLayer = "Default";

    private void Awake()
    {
        for (int i = 0; i < bulletsQuantity; i++)
        {
            BulletLogic aux = bulletFactory.GetNewInstance();
            aux.gameObject.layer = LayerMask.NameToLayer(DefaultLayer);
            bulletQueue.Enqueue(aux);
        }
    }
    
    public void SingleBulletSpawn(Transform bulletSpawn, bool isPlayer)
    {
        if (bulletQueue.Count != 0)
        {
            BulletLogic aux = bulletQueue.Dequeue();

            aux.gameObject.layer = isPlayer ? LayerMask.NameToLayer(PlayerLayer) : LayerMask.NameToLayer(EnemyLayer);

            aux.BulletSpawn = bulletSpawn;
            aux.gameObject.SetActive(true);

        }
    }

    public void MultipleBulletSpawn(Transform[] bulletSpawns, bool isPlayer) 
    { 
        if(bulletQueue.Count >= 3)
        {
            for (int i = 0; i < bulletSpawns.Length; i++)
                SingleBulletSpawn(bulletSpawns[i], isPlayer);
           
        }
    }
    

    public void ReplenishQueue(GameObject bullet)
    {
        BulletLogic aux = bullet.GetComponent<BulletLogic>();
        aux.ResetVelocity();
        bulletQueue.Enqueue(aux);
    }

}

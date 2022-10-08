using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling : MonoBehaviour
{
    [SerializeField] private BulletFactory bulletFactory;
    [SerializeField] private int bulletsQuantity;
    [SerializeField] private Queue<BulletLogic> bulletQueue = new Queue<BulletLogic>();

    private const string PlayerLayer = "PlayerBullets";
    private const string EnemyLayer = "EnemyBullets";

    private void Awake()
    {
        for (int i = 0; i < bulletsQuantity; i++)
        {
            BulletLogic aux = bulletFactory.GetNewInstance();
            bulletQueue.Enqueue(aux);
        }
    }
    
    public BulletLogic SingleBulletSpawn(Transform bulletSpawn, bool isPlayer)
    {
        if (bulletQueue.Count != 0)
        {
            BulletLogic aux = bulletQueue.Dequeue();

            aux.gameObject.layer = isPlayer ? LayerMask.NameToLayer(PlayerLayer) : LayerMask.NameToLayer(EnemyLayer);

            aux.BulletSpawn = bulletSpawn;
            aux.gameObject.SetActive(true);

            return aux;
        }
        else
            return null;
    }

    public BulletLogic MultipleBulletSpawn(Transform[] bulletSpawns, bool isPlayer) { return null; }
    
    public void ReplenishQueue(BulletLogic bullet)
    {
        
    }

}

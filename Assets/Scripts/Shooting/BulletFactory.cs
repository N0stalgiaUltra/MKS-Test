using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour, IGenericFactory<BulletLogic>
{
    [SerializeField] private BulletLogic bulletPrefab;
    public BulletLogic GetNewInstance()
    {
        var obj = Instantiate(bulletPrefab, transform);
        obj.gameObject.SetActive(false);
        return obj;
    }
}

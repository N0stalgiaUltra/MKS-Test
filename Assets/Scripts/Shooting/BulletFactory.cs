using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the Abstract Factory Pattern for the bullet
/// </summary>
public class BulletFactory : MonoBehaviour, IGenericFactory<BulletLogic>
{
    [Header ("Prefab Reference")]
    [SerializeField] private BulletLogic bulletPrefab;
    public BulletLogic GetNewInstance()
    {
        var obj = Instantiate(bulletPrefab, transform);
        obj.gameObject.SetActive(false);
        return obj;
    }
}

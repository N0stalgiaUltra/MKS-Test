using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MKS Systems/ Create Enemy Data")]
public class EnemyData : ScriptableObject
{   
    public enum EnemyType
    {
        SHOOTER,
        CHASER
    }
    public ShipData enemyShipData;
    public BulletData enemyBulletData;
    public EnemyType enemyType;
}

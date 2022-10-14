using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Hold the necessary data for the Bullet Object
/// </summary>
[CreateAssetMenu (menuName = "MKS Systems/ Create Bullet Data")]
public class BulletData : ScriptableObject
{
    public int Damage;
    public float Speed;
}

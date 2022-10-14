using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds the data for all the ships (Player and Enemies)
/// </summary>
[CreateAssetMenu (menuName = "MKS Systems/Create Ship Data")]
public class ShipData : ScriptableObject
{
    public int TotalHealth;
    public float Speed;
    public int CollisionDamage;
    
}

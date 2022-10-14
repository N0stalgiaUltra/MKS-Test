using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds the sprite data for all the ships
/// </summary>
[CreateAssetMenu (menuName = "MKS Systems/ Create Ship Sprite Data")]
public class ShipSpriteData : ScriptableObject
{
    public Sprite[] sprites;
    public Sprite damagedSprite;
}

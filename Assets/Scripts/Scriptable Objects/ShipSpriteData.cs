using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MKS Systems/ Create Ship Sprite Data")]
public class ShipSpriteData : ScriptableObject
{
    public Sprite actualSprite;
    public Sprite[] sprites;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Responsible for instantiating a Destroyed Ship when a ship is destroyed
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
public class DestroyedShip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public void Setup(Sprite newSprite)
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = newSprite;
        Destroy(this.gameObject, 5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

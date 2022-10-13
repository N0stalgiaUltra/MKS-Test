using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour, ICollider
{
    private BulletPooling bulletPooling;


    private void Awake() => bulletPooling = gameObject.GetComponentInParent<BulletPooling>();

    public void GetCollision(string objectTag) => DeactivateBullet();
    public void OnBecameInvisible() => DeactivateBullet();
    private void DeactivateBullet()
    {
        this.gameObject.SetActive(false);
        bulletPooling.ReplenishQueue(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetCollision(collision.tag);
    }


}

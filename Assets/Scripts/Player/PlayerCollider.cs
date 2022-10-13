using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour, ICollider
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private HealthController playerHealth;
    [SerializeField] private ShipData chaserData;
    [SerializeField] private ShipData playerData;
    [SerializeField] private BulletData bulletData;
    public void GetCollision(string tag)
    {
        if(tag.Equals("Island"))
            playerMovement.Speed = 0f;

        if(tag.Equals("Sea"))
            playerMovement.Speed /= 2f;

        if (tag.Equals("Enemy"))
            playerHealth.Damage(chaserData.CollisionDamage);

        if (tag.Equals("Bullet"))
            playerHealth.Damage(bulletData.Damage);
    }

    public void OutCollision() =>  playerMovement.Speed = playerData.Speed; 

    private void OnCollisionEnter2D(Collision2D collision) => GetCollision(collision.gameObject.tag);

    private void OnTriggerEnter2D(Collider2D collision) => GetCollision(collision.tag);
    private void OnTriggerExit2D(Collider2D collision) => OutCollision();

}

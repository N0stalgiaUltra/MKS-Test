using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the logic behind the bullet, moving the bullet and reseting his velocity after being inactive
/// </summary>

[RequireComponent(typeof (Rigidbody2D))]
public class BulletLogic : MonoBehaviour
{
    [Header ("Script References")]
    [SerializeField] private BulletData data;
    [Header ("Component References")]
    [SerializeField] private Rigidbody2D bulletRB;

    private int damage;
    private float speed;
    private Transform bulletSpawn;

    void Start()
    {
        damage = data.Damage;
        speed = data.Speed;
        AddVelocity();

    }

    private void OnEnable()
    {
        if(bulletSpawn != null)
            AddVelocity();

    }

    private void AddVelocity()
    {
        this.transform.localPosition = bulletSpawn.position;
        this.transform.rotation = bulletSpawn.rotation;
        bulletRB.AddForce(this.transform.right * speed, ForceMode2D.Impulse);
    }

    public void ResetVelocity()
    {
        bulletRB.velocity = Vector2.zero;

    }

    public Transform BulletSpawn { get { return bulletSpawn; } set { bulletSpawn = value; } }
    public int Damage { get { return damage; } }
    
    
}

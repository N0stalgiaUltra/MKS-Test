using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class BulletLogic : MonoBehaviour
{
    [Header ("Script References")]
    [SerializeField] private BulletData data;
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
        bulletRB.velocity = this.transform.localPosition * speed;
    }

    public void ResetVelocity()
    {
        bulletRB.velocity = Vector2.zero;

    }

    public Transform BulletSpawn { get { return bulletSpawn; } set { bulletSpawn = value; } }
    public int Damage { get { return damage; } }
    
    
}

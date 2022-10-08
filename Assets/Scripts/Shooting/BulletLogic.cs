using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class BulletLogic : MonoBehaviour
{
    [SerializeField] private BulletData data;
    private int damage;

    [SerializeField] private Rigidbody2D bulletRB;
    [SerializeField] private float speed;

    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private bool isMoving; 

    void Start()
    {
        damage = data.Damage;
        speed = data.Speed;

        this.transform.localPosition = bulletSpawn.position;
        isMoving = false;
    }

    void FixedUpdate()
    {
        // Reminder: Added the bullet prefab, bullet logic and Scriptable Object for bullets; 
        //TODO: fix the rotation bug
        if (gameObject.activeSelf)
        {
            bulletRB.AddForce(new Vector2(bulletSpawn.position.x, bulletSpawn.position.y) * (speed * Time.fixedDeltaTime), ForceMode2D.Impulse);
        }
    }

    //private void OnEnable()
    //{
    //    if (!isMoving && bulletSpawn != null)
    //        this.transform.localPosition = bulletSpawn.position;
    //}

    private void ResetVelocity()
    {
        bulletRB.velocity = Vector2.zero;
        isMoving = false;
    }

    public Transform BulletSpawn { get { return bulletSpawn; } set { bulletSpawn = value; } }
    public int Damage { get { return damage; } }
    
    
}

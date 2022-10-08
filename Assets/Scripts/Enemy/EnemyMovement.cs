using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;
    [SerializeField] private Rigidbody2D enemyRB;

    [SerializeField] private Transform playerTransform;
    private float speed;
    [SerializeField] private float rotateSpeed;
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        speed = enemyData.enemyShipData.Speed;
    }

    void Update()
    {
        Move();
        Rotate();
    }
    
    private void Move()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, playerTransform.position, speed * Time.deltaTime);
    }

    private void Rotate()
    {
        Vector3 targetPos = playerTransform.position;
        Vector2 offset = new Vector2(transform.position.x - targetPos.x, transform.position.y - targetPos.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        this.transform.rotation = Quaternion.Euler(0, 0, angle - 90f);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    [SerializeField] protected Transform playerTransform;

    [SerializeField] protected float rotateSpeed;
    void Start()
    {
        playerTransform = GameObject.Find("PlayerShip").GetComponent<Transform>();
    }

    protected void Move(float enemySpeed)
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, enemySpeed * Time.deltaTime);
    }

    protected virtual void Rotate()
    {
        Vector3 targetPos = playerTransform.position;
        Vector2 offset = new Vector2(transform.position.x - targetPos.x, transform.position.y - targetPos.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        this.transform.rotation = Quaternion.Euler(0, 0, angle - 90f);

    }
}

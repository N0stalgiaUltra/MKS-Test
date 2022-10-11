using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    protected Transform playerTransform;

    [SerializeField] protected float rotateSpeed;
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    protected void Move(float speed)
    {
        transform.position = Vector3.MoveTowards(this.transform.position, playerTransform.position, speed * Time.deltaTime);
    }

    protected virtual void Rotate()
    {
        Vector3 targetPos = playerTransform.position;
        Vector2 offset = new Vector2(transform.position.x - targetPos.x, transform.position.y - targetPos.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        this.transform.rotation = Quaternion.Euler(0, 0, angle - 90f);

    }
}

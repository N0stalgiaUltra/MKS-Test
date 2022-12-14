using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the Player Rotation
/// </summary>
public class PlayerRotation : MonoBehaviour
{
    [Header ("Rotation Speed")]
    [SerializeField] private float rotateSpeed; 


    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 targetPos = Camera.main.WorldToScreenPoint(transform.localPosition);
        Vector2 offset = new Vector2(mousePos.x - targetPos.x, mousePos.y - targetPos.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        Quaternion targetRot = Quaternion.Euler(0, 0, angle + 90f);
        this.transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, rotateSpeed * Time.deltaTime);

    }
}

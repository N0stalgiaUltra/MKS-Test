using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLimit : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform leftPoint;
    [SerializeField] private Transform rightPoint;
    [SerializeField] private Transform downPoint;
    [SerializeField] private Transform upPoint;

    void Update()
    {
        CheckHorizontal();
        CheckVertical();
    }

    private void CheckHorizontal()
    {
        if(playerTransform.position.x > rightPoint.position.x)
            playerTransform.position = new Vector2(leftPoint.position.x, playerTransform.position.y);
        
        else if(playerTransform.position.x < leftPoint.position.x)
            playerTransform.position = new Vector2(rightPoint.position.x, playerTransform.position.y);

    }

    private void CheckVertical()
    {
        if(playerTransform.position.y > upPoint.position.y)
            playerTransform.position = new Vector2(playerTransform.position.x, downPoint.position.y);
        
        else if(playerTransform.position.y < downPoint.position.y)
            playerTransform.position = new Vector2(playerTransform.position.x, upPoint.position.y);


    }
}

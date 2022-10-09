using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public enum CharType
    {
        PLAYER,
        ENEMY
    }

    [SerializeField] private CharType charType;
    [SerializeField] private ShipData shipData;
    private int health;
    void Start()
    {
        health = shipData.TotalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            Die();
    }

    public void Damage(int value)
    {
        if (health > 0)
            health -= value;
        else
            return;
    }

    private void Die()
    {
        if (this.charType == CharType.PLAYER)
        { //TODO: set game over, replenish enemy queue
        }
        this.gameObject.SetActive(false);
    }
    
}

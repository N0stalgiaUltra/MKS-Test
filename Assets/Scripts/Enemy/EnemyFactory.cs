using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Generic Factory Pattern for the Enemy type
/// </summary>
public class EnemyFactory : MonoBehaviour, IGenericFactory<GameObject>
{
    [SerializeField] private GameObject[] enemies = new GameObject[2]; 
    public GameObject GetNewInstance()
    {
        var aux = Instantiate(enemies[Random.Range(0, enemies.Length)], this.transform);
        aux.SetActive(false);
        return aux;
    }
}

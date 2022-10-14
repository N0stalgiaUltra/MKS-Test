using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used for destroying the Explosion 
/// </summary>
public class ExplosionAnimation : MonoBehaviour
{

    private void Start()
    {
        Destroy(this, 5f);
    }


}

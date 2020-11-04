using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyHealth enemyHealth = null;

    void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }
}

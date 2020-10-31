using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDebug : MonoBehaviour
{
    [SerializeField] Health healthScript;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            healthScript.damage = 10f;
            healthScript.GiveDamage();
        }
    }
}

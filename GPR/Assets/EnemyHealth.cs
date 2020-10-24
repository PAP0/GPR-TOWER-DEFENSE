using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float damage;
    //public float lifetime = 1f;

    public GameObject healthbarUI;
    public Slider slider1;
    public Slider slider2;

    void Start()
    {
        health = maxHealth;
        slider1.value = CalculateHealth();
        slider2.value = CalculateHealth();
        healthbarUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            health -= damage;
        }

        slider1.value = CalculateHealth();
        slider2.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthbarUI.SetActive(true);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //NOTE: HEALTH EN HEALTHBAR OPSPLITSEN IN 2 APARTE SCRIPTS
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
        slider1.value = CalculateHealth();
        slider2.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthbarUI.SetActive(true);
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }

    public void GiveDamage()
    {
        health -= damage;
    }
}

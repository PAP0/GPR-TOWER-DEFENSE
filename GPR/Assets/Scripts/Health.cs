using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityEvent onGiveDamage;
    public UnityEvent onDie;
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

    public virtual void GiveDamage(float amount)
    {
        health -= amount;
        if (health <= 0) onDie.Invoke();
        onGiveDamage.Invoke();
    }
    public float Gethealth()
    {
        return this.health;
    }

    public float GetMaxHealth()
    {
        return this.maxHealth;
    }
}

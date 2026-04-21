using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;

    public float currentHealth;

    public Action<float> OnHealthChanged;

    void Awake()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        OnHealthChanged?.Invoke(currentHealth / maxHealth);
    }
}

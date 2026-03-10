using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOverScript;
    [SerializeField] float maxHealth = 100f;

    float currentHealth;

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

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            if(gameOverScript != null) gameOverScript.ActiveGameOver();
        }
    }
}

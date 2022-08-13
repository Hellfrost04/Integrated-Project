using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class PlayerStats : CharacterStats
    {
        HealthBar healthBar;
        AnimationHandler animationHandler;

        private void Awake()
        {
            healthBar = FindObjectOfType<HealthBar>();
            animationHandler = GetComponentInChildren<AnimationHandler>();
        }

        void Start()
        {
            maxHealth = SetMaxHealth();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
            healthBar.SetCurrentHealth(currentHealth);
        }

        private int SetMaxHealth()
        {
            maxHealth = healthLevel * 2;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;
            healthBar.SetCurrentHealth(currentHealth);

            if(currentHealth <= 0)
            {
                currentHealth = 0;
                animationHandler.PlayTargetAnimation("Death", true);
            }
        }
    }
}
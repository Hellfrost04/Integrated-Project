using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class PlayerStats : MonoBehaviour
    {
        public int healthLevel = 10;
        public int maxHealth;
        public int currentHealth;

        public HealthBar healthBar;
        AnimationHandler animationHandler;

        private void Awake()
        {
            animationHandler = GetComponentInChildren<AnimationHandler>();
        }

        void Start()
        {
            maxHealth = SetMaxHealth();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class PlayerStats : CharacterStats
    {
        PlayerManager playerManager;
        public HealthBar healthBar;
        AnimationHandler animationHandler;

        private void Awake()
        {
            playerManager = GetComponent<PlayerManager>();

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
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            if (playerManager.isInvulerable)
            {
                return;
            }
            if (isDead)
            {
                return;
            }

            currentHealth = currentHealth - damage;

            healthBar.SetCurrentHealth(currentHealth);

            if(currentHealth <= 0)
            {
                currentHealth = 0;
                animationHandler.PlayTargetAnimation("Death", true);
                isDead = true;
            }
        }
    }
}
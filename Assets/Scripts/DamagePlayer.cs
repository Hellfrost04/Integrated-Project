using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class DamagePlayer : MonoBehaviour
    {
        public int damage = 2;

        private void OnTriggerEnter(Collider other)
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();

            if(playerStats != null)
            {
                playerStats.TakeDamage(damage);
                Debug.Log("Damaged");
            }
        }
    }
}
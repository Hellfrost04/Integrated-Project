using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{

    public class PlayerAttacker : MonoBehaviour
    {
        AnimationHandler animationHandler;

        private void Awake()
        {
            animationHandler = GetComponentInChildren<AnimationHandler>();
        }

        public void HandleLightAttack(WeaponItem weapon)
        {
            animationHandler.PlayTargetAnimation(weapon.OH_Light, true);
        }

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            animationHandler.PlayTargetAnimation(weapon.OH_Heavy, true);
        }
    }
}
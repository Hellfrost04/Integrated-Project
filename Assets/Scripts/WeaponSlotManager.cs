using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class WeaponSlotManager : MonoBehaviour
    {
        PlayerManager playerManager;

        WeaponHolderSlot rightHandSlot;

        DamageCollider rightDamageCollider;

        private void Awake()
        {
            playerManager = GetComponentInParent<PlayerManager>();
            WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
            foreach (WeaponHolderSlot weaponSlot in weaponHolderSlots)
            {
                if (weaponSlot.isRightHandSlot)
                {
                    rightHandSlot = weaponSlot;
                }
            }
        }

        public void LoadWeaponOnSlot(WeaponItem weaponItem)
        {
            rightHandSlot.LoadWeaponModel(weaponItem);
            LoadDamageCollider();
        }

        private void LoadDamageCollider()
        {
            rightDamageCollider = rightHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
        }

        public void OpenDamageCollider()
        {
            rightDamageCollider.EnableDamageCollider();
        }

        public void CloseDamageCollider()
        {
            rightDamageCollider.DisaleDamageCollider();
        }
    }
}
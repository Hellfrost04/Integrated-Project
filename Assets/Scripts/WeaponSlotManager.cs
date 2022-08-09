using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class WeaponSlotManager : MonoBehaviour
    {
        WeaponHolderSlot rightHandSlot;

        private void Awake()
        {
            WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
            foreach (WeaponHolderSlot weaponSlot in weaponHolderSlots)
            {
                if(weaponSlot.isRightHandSlot)
                {
                    rightHandSlot = weaponSlot;
                }
            }
        }

        public void LoadWeaponOnSlot(WeaponItem weaponItem)
        {
         rightHandSlot.LoadWeaponModel(weaponItem);
       
        }
    }
}
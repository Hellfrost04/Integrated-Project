using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    [CreateAssetMenu(menuName = "Item/Weapon")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("One Handed Attacks")]
        public string OH_Light;
        public string OH_Heavy;
    }
}
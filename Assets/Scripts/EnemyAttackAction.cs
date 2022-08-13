using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    [CreateAssetMenu(menuName = "A.I/Enemy Actions/Attack Action")]
    public class EnemyAttackAction : EnemyAction
    {
        public int attackScore = 3;
        public float recoveryTime = 0;

        public float maximumAttackAngle = 360;
        public float minimumAttackAngle = -360;

        public float minimumDistanceNeededToAttack = 0;
        public float maximumDistanceNeededToAttack = 11;
    }
}
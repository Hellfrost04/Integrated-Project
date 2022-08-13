﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class PursueTargetState : State
    {
        public override State Tick(EnemyManager enemyManager, EnemyStats enemyStats, EnemyAnimatorManager enemyAnimatorManager)
        {
            //Chase the target
            //If within attack range, return combat stance state
            //if target is out of range, return this state and continue to chase target
            return this;
        }
    }
}
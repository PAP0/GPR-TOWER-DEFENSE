using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperTower : BaseTower
{
    protected override void Attack()
    {
        Enemy[] enemies = EnemyInRangeChecker.GetAllEnemiesInRangeFromLocation(Targets[0].gameObject.transform.position, 1);
        foreach (var target in enemies)
        {
            target.enemyHealth.GiveDamage(damage);
        }
        Targets.Clear();
    }

    protected override bool CanAttack()
    {
        Enemy enemy = EnemyInRangeChecker.GetClosestEnemyInRange();
        if (enemy == null) return false;
        Targets.Add(enemy);
        return true;
    }
}

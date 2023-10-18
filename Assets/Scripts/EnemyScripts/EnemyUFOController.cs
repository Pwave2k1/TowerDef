using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyUFOController : EnemyBase
{
    private void Start()
    {
        _hp = _enemySO.Hp;
        _moveSpeed = _enemySO.MoveSpeed;
        _target = PositionMoveController._positionMovePrefabs[0];
    }
    private void Update()
    {
        MoveEnemy();
    }
    public override void MoveEnemy()
    {
        Vector3 dir = _target.position - transform.position;
        transform.Translate(dir.normalized * _moveSpeed * 10f * Time.deltaTime);
        if (Vector3.Distance(transform.position, _target.position) <= 0.2f)
        {
            GetNextIndex();
        }
    }
    public override void GetNextIndex()
    {
        if (cout >= PositionMoveController._positionMovePrefabs.Length - 1)
        {
            Destroy(gameObject);
        }
        else
        {
            cout++;
            _target = PositionMoveController._positionMovePrefabs[cout];
        }
    }

}

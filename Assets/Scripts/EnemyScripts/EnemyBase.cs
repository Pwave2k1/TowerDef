using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [SerializeField] protected EnemySO enemySO;
    public EnemySO _enemySO => enemySO;
    [SerializeField] protected int _hp;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected Transform _target;
    [SerializeField] protected int cout;

    public abstract void MoveEnemy();
    public abstract void GetNextIndex();
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemySO")]
public class EnemySO : ScriptableObject
{
    public int Hp = 100;
    public float MoveSpeed = 2f;
}

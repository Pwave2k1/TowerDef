using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PositionMoveController : MonoBehaviour
{
    public static Transform[] _positionMovePrefabs;
    private void Awake()
    {
        LoadPos();
    }
    private void Start()
    {
        if (_positionMovePrefabs == null)
        {
            Debug.Log("null");
        }
    }
    private void LoadPos()
    {
        _positionMovePrefabs = new Transform[transform.childCount];
        for (int i = 0; i <= _positionMovePrefabs.Length - 1; i++)
        {
            _positionMovePrefabs[i] = transform.GetChild(i);
        }
    }

}

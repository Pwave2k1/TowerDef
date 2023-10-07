using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] private GameObject _spawnerEnemyPlace;
    [SerializeField] private GameObject _targetEnemyPlace;
    [SerializeField] private GameObject _enemyPrefabs;
    [SerializeField] private List<GameObject> _listEnemy;

    private void Awake()
    {
        LoadEnemy();
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemiesWithDelay(2f));
    }

    private void LoadEnemy()
    {
        foreach (Transform item in _enemyPrefabs.transform)
        {
            _listEnemy.Add(item.gameObject);
        }
    }

    private IEnumerator SpawnEnemiesWithDelay(float delay)
    {
        while (true)
        {
            foreach (GameObject enemyPrefab in _listEnemy)
            {
                if (_spawnerEnemyPlace != null)
                {
                    Instantiate(enemyPrefab, _spawnerEnemyPlace.transform.position, Quaternion.identity);
                }
                yield return new WaitForSeconds(delay);
            }
        }
    }
}

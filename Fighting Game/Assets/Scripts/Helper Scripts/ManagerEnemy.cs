using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemy : MonoBehaviour {

    public static ManagerEnemy instance;

    [SerializeField]
    private GameObject enemyPrefab;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

}

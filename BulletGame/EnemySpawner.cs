using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 적을 생성하는 스크립트
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 3f;
    public float timeElapsed;
    public int maxEnemyCount = 5;
    public int currentEnemyCount = 1;

    private void Start()
    {
        SpawnEnemys();
    }

    private void Update()
    {
        // 시간의 경과
        timeElapsed += Time.deltaTime;

        if (timeElapsed > spawnTime && currentEnemyCount < maxEnemyCount)
        {
            SpawnEnemys();
            timeElapsed = 0;
        }
    }

    private void SpawnEnemys()
    {
        // 스폰 지점
        Vector3 spawnPoint = new Vector3(Random.Range(-13f, 13f), 0.5f, Random.Range(-13f, 13f));

        // 프리펩을 생성
        GameObject temp = Instantiate(enemyPrefab);

        // 생성된 오브젝트의 위치를 지정
        temp.transform.position = spawnPoint;

        currentEnemyCount++;
    }

}
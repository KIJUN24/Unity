using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �����ϴ� ��ũ��Ʈ
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
        // �ð��� ���
        timeElapsed += Time.deltaTime;

        if (timeElapsed > spawnTime && currentEnemyCount < maxEnemyCount)
        {
            SpawnEnemys();
            timeElapsed = 0;
        }
    }

    private void SpawnEnemys()
    {
        // ���� ����
        Vector3 spawnPoint = new Vector3(Random.Range(-13f, 13f), 0.5f, Random.Range(-13f, 13f));

        // �������� ����
        GameObject temp = Instantiate(enemyPrefab);

        // ������ ������Ʈ�� ��ġ�� ����
        temp.transform.position = spawnPoint;

        currentEnemyCount++;
    }

}
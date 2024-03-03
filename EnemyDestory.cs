using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestory : MonoBehaviour
{
    EnemySpawner enemySpawner;

    private void Start()
    {
        enemySpawner = FindObjectOfType<EnemySpawner>();
    }


    // 충돌할 때 호출되는 함수
    void OnTriggerEnter(Collider other)
    {
        // 충돌한 객체가 플레이어인지 확인
        if (other.CompareTag("Player"))
        {
            // 충돌한 객체가 플레이어인 경우에만 파괴
            enemySpawner.currentEnemyCount--;
            Destroy(gameObject);
        }
    }
}

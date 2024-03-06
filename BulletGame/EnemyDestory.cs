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


    // �浹�� �� ȣ��Ǵ� �Լ�
    void OnTriggerEnter(Collider other)
    {
        // �浹�� ��ü�� �÷��̾����� Ȯ��
        if (other.CompareTag("Player"))
        {
            // �浹�� ��ü�� �÷��̾��� ��쿡�� �ı�
            enemySpawner.currentEnemyCount--;
            Destroy(gameObject);
        }
    }
}

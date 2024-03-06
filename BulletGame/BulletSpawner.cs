using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner: MonoBehaviour
{

    // �Ѿ� �������� ���� ���� ����
    public GameObject bulletPrefab;

    //�ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;

    // �ִ� ���� �ֱ�
    public float spawnRateMax = 3.5f;

    // �߻��� ���
    Transform target;

    // �Ѿ� ���� �ֱ�
    float spawnRate;

    // �ֱ� ���� �� �������� ���� �ð�
    float timeAfterSpawn;

    Vector3 offset = Vector3.zero;
    // Vector3 offset2 = new Vector3(0, 0, 0);  // �� �ڵ�� ������

    void Start()
    {
        // ������ �Ѿ��� �߻�� ���� ������ �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0;

        // �Ѿ� ���� �ֱ� �������� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // Ÿ�� ����
        target = FindObjectOfType<Player_1>().transform;
    }

    void Update()
    {
        // ���� �ð��� ��� ����
        timeAfterSpawn += Time.deltaTime;   // ������ �ð��� ���� �ð��� ����
        

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            Vector3 targetPos = target.position;
            
            // Y���� ���ϴ� ���̷� ����
            offset += new Vector3(0, 0.5f, 0);

            Vector3 newTarget = target.position + offset;
            
            /*bullet.transform.LookAt(target);*/
            bullet.transform.LookAt(newTarget);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        }
    }
}

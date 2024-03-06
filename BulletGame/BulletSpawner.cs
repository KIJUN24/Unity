using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner: MonoBehaviour
{

    // 총알 프리펩을 담을 변수 선언
    public GameObject bulletPrefab;

    //최소 생성 주기
    public float spawnRateMin = 0.5f;

    // 최대 생성 주기
    public float spawnRateMax = 3.5f;

    // 발사할 대상
    Transform target;

    // 총알 생성 주기
    float spawnRate;

    // 최근 생성 된 시점에서 지난 시간
    float timeAfterSpawn;

    Vector3 offset = Vector3.zero;
    // Vector3 offset2 = new Vector3(0, 0, 0);  // 위 코드와 동일함

    void Start()
    {
        // 마지막 총알이 발사된 이후 누적된 시간을 0으로 초기화
        timeAfterSpawn = 0;

        // 총알 생성 주기 랜덤으로 생성
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // 타겟 설정
        target = FindObjectOfType<Player_1>().transform;
    }

    void Update()
    {
        // 현재 시간을 계속 누적
        timeAfterSpawn += Time.deltaTime;   // 마지막 시간과 현재 시간에 간격
        

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            Vector3 targetPos = target.position;
            
            // Y값을 원하는 높이로 변경
            offset += new Vector3(0, 0.5f, 0);

            Vector3 newTarget = target.position + offset;
            
            /*bullet.transform.LookAt(target);*/
            bullet.transform.LookAt(newTarget);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        }
    }
}

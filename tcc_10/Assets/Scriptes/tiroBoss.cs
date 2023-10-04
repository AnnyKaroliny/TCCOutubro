using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroBoss : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 2.0f; // taxa de tiro por segundo

    private float nextfireTime;

    private void Start()
    {
        nextfireTime = Time.time + 1.0f / fireRate;
    }

    private void Update()
    {
        if (Time.time >= nextfireTime)
        {
            shoot();
            nextfireTime = Time.time + 1.0f / fireRate;
        }
    }

    private void shoot()
    {
        // cria uma instancia (bala) no ponto de disparo
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroBoss : MonoBehaviour
{
    public float fireRate = 2.0f; // taxa de tiro por segundo
    public float velocidade;
    private float nextfireTime;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform posicaoPlayer;
    public Transform posicaoInicialInimigo;

    private void Start()
    {
        nextfireTime = Time.time + 1.0f / fireRate;
        rb = GetComponent<Rigidbody2D>();
    }
       
    private void Update()
    {
        if (Time.time >= nextfireTime)
        {
            shoot();
            nextfireTime = Time.time + 1.0f / fireRate;
        }
        StartCoroutine(atacarInimigo());
    }

    private void shoot()
    {
        // cria uma instancia (bala) no ponto de disparo
       Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);       
    }

    IEnumerator atacarInimigo()
    {
        yield return new WaitForSeconds(2f);

        transform.position = Vector2.MoveTowards(transform.position, posicaoPlayer.position, velocidade * Time.deltaTime);

        yield return new WaitForSeconds(2f);

        posicaoPlayer.position = Vector2.MoveTowards(posicaoPlayer.position, posicaoInicialInimigo.transform.position, velocidade * Time.deltaTime);

        yield return new WaitForSeconds(1f);

        if (Time.time >= nextfireTime)
        {
            shoot();
            nextfireTime = Time.time + 1.0f / fireRate;
        }
    }
}

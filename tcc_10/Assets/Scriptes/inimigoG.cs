using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoG : MonoBehaviour
{
    private float speed = 5;
    public int trocardirecao;



    private void Start()
    {
        trocardirecao = 1;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * speed * trocardirecao * Time.deltaTime);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "sensorG1")
        {

            trocardirecao = 1;

        }
        if (collision.gameObject.tag == "sensorG2")
        {

            trocardirecao = -1;

        }



    }
}

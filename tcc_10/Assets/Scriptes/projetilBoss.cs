using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetilBoss : MonoBehaviour
{
    public float moveSpeed = 5.0f; // velocidade de movimento
    public float destroyXPosition = -10.0f; // posi�ao X para destruir o objeto

    private void Update()
    {
        // mova o objeto para esquerda
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        // verifique se o obejto esta alem do X de destrui�ao
        if (transform.position.x <= destroyXPosition)
        {
            // destrua o objeto
            Destroy(gameObject);
        }
    }
}

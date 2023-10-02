using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoTransicao : MonoBehaviour
{
    public GameObject[] cenas;
    public int contador;


    void Start()
    {

    }

    public void proximaCena()
    {
        contador = contador + 1;
       
        cenas[contador].SetActive(true);

    }

    public void voltarCena()
    {
        cenas[contador].SetActive(false);
        contador = contador - 1;
       

    }






}

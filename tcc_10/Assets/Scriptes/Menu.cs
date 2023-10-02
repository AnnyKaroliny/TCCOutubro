using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void IniciarJogo()
    {
        SceneManager.LoadScene("Introdução");
    }

    public void Retornar()
    {
        SceneManager.LoadScene("Tela Inicial");
    }

    public void TelaInicial()
    {
        SceneManager.LoadScene("Tela Inicial");
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }
}

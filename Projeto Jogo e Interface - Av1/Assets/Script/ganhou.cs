using System;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;

public class GerenciadorDeVitoria : MonoBehaviour
{
    public TMP_Text contadorKillsTexto;
    public TMP_Text textoVitoria;

    public int killsNecessarias = 10;
    public bool congelarJogoAoFinal = true;

    public int killsAtuais = 0;
    private bool venceu = false;

    void Start()
    {
        contadorKillsTexto.text = "Kills: 0";
        textoVitoria.gameObject.SetActive(false);
    }


    private void Update()
    {
       contadorKillsTexto.text = killsAtuais.ToString();

        if (killsAtuais >= killsNecessarias)
        {
            venceu = true;
            textoVitoria.gameObject.SetActive(true);
            textoVitoria.text = "Você ganhou!";
            Debug.Log("Vitória!");
        }
        
    }
}
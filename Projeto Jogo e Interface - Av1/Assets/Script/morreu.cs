using UnityEngine;

public class PlayerDesapareceAoMorrer : MonoBehaviour
{
    private Personagem personagem; 
    private bool morreu = false;

    void Start()
    {
        personagem = GetComponent<Personagem>();
    }

    void Update()
    {
        if (!morreu && personagem.getVida() <= 0)
        {
            morreu = true;
            gameObject.SetActive(false); // Faz o Player sumir
        }
    }
}


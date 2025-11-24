using UnityEngine;
using TMPro;

public class perdeu : MonoBehaviour
{
    public TMP_Text textoDerrota;
    public Player player;

    void Start()
    {
        textoDerrota.gameObject.SetActive(false); // começa escondido
    }

    void Update()
    {
        if (player.getVida() <= 0)
        {
            textoDerrota.gameObject.SetActive(true);
            textoDerrota.text = "Você perdeu!";
        }
        
    }
}


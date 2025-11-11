using UnityEngine;
using TMPro;

public class ContagemRegressiva : MonoBehaviour
{
    public float tempo = 60f;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;

    void Update()
    {
        tempo -= Time.deltaTime;
        int s = Mathf.RoundToInt(tempo);
        texto.text = s.ToString();
        
        if (s <= 0) 
        {
            texto.gameObject.SetActive(false); // Texto some!
            texto2.gameObject.SetActive(false); // Texto some!
        }
    }
}


using TMPro;
using UnityEngine;

public class InimigosAbatidos : MonoBehaviour
{
    public int numerodeInimigos = 0;
    
    public TMP_Text PlacarInimigos;
    
    void Start()
    {
        
    }

 
    void Update()
    {
      PlacarInimigos.text = numerodeInimigos.ToString();   
    }
}

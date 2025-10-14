using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int volume; // Serializable
    public int volumesfx; // Serializable
    public bool musica; // Serializable
    
    public Slider volumeSlider; // Serializable
    public Slider volumesfxSlider; // Serializable
    public Toggle toggleMusica; // Serializable
    public TMP_Text textoMusica; // Serializable
    
    void Start()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumesfx = (int)volumesfxSlider.value;
    }
    
    void Update()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumesfx = (int)volumesfxSlider.value;
        
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumesfx = (int)volumesfxSlider.value; 
        
        if (musica == true)
        {
            textoMusica.text = "Ligado";
            textoMusica.color = Color.green;
        }
        else
        {
            textoMusica.text = "Desligado";
            textoMusica.color = Color.red;
        }
    }
}

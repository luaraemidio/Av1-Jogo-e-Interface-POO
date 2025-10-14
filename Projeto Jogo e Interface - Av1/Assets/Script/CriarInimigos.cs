using UnityEngine;

public class CriarInimigos : MonoBehaviour
{
   
    public GameObject[] inimigos; 
    
    public float tempoDoNovoInimigo = 15; //segundos
    public float distanciaInimigo = 5;
    
    private float cronometroInimigo = 0;
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        cronometroInimigo += Time.deltaTime;

        if (cronometroInimigo >= tempoDoNovoInimigo)
        {
            GameObject inimigo = Instantiate(inimigos[Random.Range(0, inimigos.Length)], 
                new Vector3(transform.position.x+Random.Range(-distanciaInimigo,distanciaInimigo), 
                    transform.position.y+Random.Range(-distanciaInimigo,distanciaInimigo), transform.position.z), 
                transform.rotation) as GameObject;
            
            cronometroInimigo = 0;
        }
    }
}
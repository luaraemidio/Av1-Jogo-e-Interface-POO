using UnityEngine;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    public Transform arma;

    private bool amdando;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        amdando = false;
        
        

        //movimento para a esquerda
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);  
            amdando = true;
        }

        //movimento para a direita
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            amdando = true;
        }
        
        //movimento para a Cima
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0); 
            amdando = true;
        }
        
        //movimento para a Cima
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);  
            amdando = true;
        }
        
        animator.SetBool("Andando", amdando);
    }
}

using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField] private int dano = 1;
    
    public float raioDeVisao = 1;
    public CircleCollider2D _visaoCollider2D;

    [SerializeField] private Transform posicaoDoPlayer;
    
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    public AudioSource audioSource;

    private bool andando = false;
    
    private InimigosAbatidos inimigosAbatidos;
    
    public void setDano(int dano)
    {
        this.dano = dano;
    }
    public int getDano()
    {
        return this.dano;
    }
    
    
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
        if (posicaoDoPlayer == null)
        {
            posicaoDoPlayer =  GameObject.Find("Player").transform;
           // posicaoDoPlayer =  GameObject.FindGameObjectsWithTag("Player")[0].transform;
        }

        inimigosAbatidos = GameObject.Find("Placar").GetComponent<InimigosAbatidos>();
        
        raioDeVisao = _visaoCollider2D.radius;
        
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        andando = false;
        
      //  gameObject.transform.LookAt(posicaoDoPlayer, Vector3.up);
      
      
      // Calculate direction from this object to the target
      Vector3 direction = posicaoDoPlayer.position - transform.position;

      // Calculate angle in degrees (atan2 handles all quadrants)
      float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

      // Apply rotation around Z-axis only (2D rotation)
      transform.rotation = Quaternion.Euler(0f, 0f, angle);
        
        
        if (posicaoDoPlayer != null && 
            Vector3.Distance(posicaoDoPlayer.position, transform.position) <= raioDeVisao )
        {
            Debug.Log("Posição do Pluer"+ posicaoDoPlayer.position);
            
            transform.position = Vector3.MoveTowards(transform.position, 
                posicaoDoPlayer.transform.position,
                getVelocidade() * Time.deltaTime);
            
            andando = true;
        }
        
        if (getVida() <= 0)
        {
            inimigosAbatidos.numerodeInimigos += 1;
            //desativa o objeto do Inimigo
            gameObject.SetActive(false);
          
        }
        
       // animator.SetBool("Andando",andando);

    }

    public void playAudio()
    {
        audioSource.Play();
    }
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Causa dano ao Player
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVida() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVida(novaVida);

            //collision.gameObject.GetComponent<Personagem>().recebeDano(getDano());
            
            //desativa quando bate no player
            
            inimigosAbatidos.numerodeInimigos += 1;
            gameObject.SetActive(false);
        }
    }

}

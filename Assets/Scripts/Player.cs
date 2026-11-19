using UnityEditor.SceneManagement;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed = 5f; //Velocidade do jogador em float (numros racionais)

    private Rigidbody2D rb; //Variável RigidBody será atribuida a "rb"

    private bool IsGrounded = false; //Variável que indica se algo está tocando em um objeto com a tag "Ground" (inicialmente falsa)

    public MenuScene menu; //Variável MenuScene atribuida a "menu"

    void Start() //Ao iniciar o jogo
    {
        rb = GetComponent<Rigidbody2D>(); //Atribuindo RigidBody à variável rb
    }

    void Update() //Ao atualizar cada frame
    {
        float movehorizontal = Input.GetAxis("Horizontal"); //Cria e atribui uma variável float ao movimento horizontal (eixo x) pelas teclas "a", "d", "Seta p/ direita" e "Seta p/ esquerda"

        rb.linearVelocity = new Vector2(movehorizontal * speed, rb.linearVelocity.y); //Faz o player se movimentar somente na horizontal

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded) //Se a tecla "Espaço" for acionada e o Player estiver encostando em um objeto com a tag "Ground"
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); //Vai adicionar força ao pulo quando a tecla "Espaço" estiver pressionada
        }
    }

    void OnCollisionEnter2D(Collision2D collision) //Ao acionar uma colisão
    {
        if (collision.gameObject.CompareTag("Ground")) //Verificar se algum objeto com a tag "Ground" está sendo encostado pelo Player
        {
            IsGrounded = true; //Vai reconhecer quando o jogador estiver encostando no chão e permite andar horizontalmente
        }

        if (collision.gameObject.CompareTag("Dano")) //Ao reconhecer a colisão do Player com um objeto com a tag "Dano"
        {
            menu.MostrarGameOver(); //Vai Mostrar a tela de Game Over
        }
        if (collision.gameObject.CompareTag("EndPhase")) //Ao reconhecer a colisão do Player com um objeto com a tag "EndPhase"
        {
            menu.MostrarVitoria(); //Vai Mostrar a tela de Vitóra
        }
    }
   void OnCollisionExit2D(Collision2D collision) //Ao desativar uma colisão
    {
        if (collision.gameObject.CompareTag("Ground")) //verificar se foi a tag "Ground" que obteve exit na colisão
        {
            IsGrounded = false; //Deixará a variável "IsGrounded" desativada impossibilitando o jogador de pular
        }
    }
}
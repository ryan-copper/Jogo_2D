using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    private bool IsGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Atribuindo RigidBody à variável rb
    }

    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(movehorizontal * speed, rb.linearVelocity.y); //Faz o player se movimentar somente na horizontal

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); //Vai adicionar força ao pulo quando a tecla "Espaço" estiver pressionada
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true; //Vai reconhecer quando o jogador estiver encostando no chão
        }

        if (collision.gameObject.CompareTag("Dano"))
        {
            SceneManager.LoadScene(0); //reseta a fase quando o player encosta em um objeto com a tag "Dano"
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false; //Vai reconhecer quando o jogador não estiver encostando no chão
        }
    }
}
using UnityEngine;

public class EnemyChaseAndJump : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public float moveSpeed = 2f; // Velocidad de movimiento del enemigo
    public float stoppingDistance = 2f; // Distancia a la que el enemigo se detiene del jugador
    public float jumpForce = 5f; // Fuerza del salto del enemigo
    public LayerMask groundLayer; // Capa que representa el suelo
    public float groundCheckDistance = 0.1f; // Distancia para chequear si el enemigo está en el suelo

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player != null)
        {
            // Calcular la dirección hacia el jugador
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            // Si la distancia al jugador es mayor que la distancia de parada, mover al enemigo
            if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
            {
                transform.position += direction * moveSpeed * Time.deltaTime;
            }

            // Verificar si el enemigo está en el suelo
            isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);

            // Si el jugador está en una posición más alta que el enemigo y el enemigo está en el suelo, saltar
            if (player.position.y > transform.position.y && isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }
}
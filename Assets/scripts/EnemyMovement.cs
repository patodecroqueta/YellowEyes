using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public float moveSpeed = 3f; // Velocidad de movimiento del enemigo
    public float stoppingDistance = 1f; // Distancia a la que el enemigo se detiene frente al jugador
    public Animator animator; // Referencia al Animator del enemigo

    void Update()
    {
        // Calcula la dirección hacia la que debe moverse el enemigo
        Vector3 targetDirection = player.position - transform.position;
        targetDirection.y = 0f; // Mantén el movimiento en el plano horizontal

        // Si el jugador está en la vista del enemigo
        if (CanSeePlayer())
        {
            // Mira hacia el jugador
            transform.rotation = Quaternion.LookRotation(targetDirection);

            // Si el enemigo no está en la distancia de parada, camina hacia el jugador
            if (targetDirection.magnitude > stoppingDistance)
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                // Cambia al estado de caminar en el Animator
                animator.SetBool("isWalking", true);
            }
            else
            {
                // Detiene al enemigo
                animator.SetBool("isWalking", false);
            }
        }
        else
        {
            // Cambia al estado de idle en el Animator si el jugador no está en la vista del enemigo
            animator.SetBool("isWalking", false);
        }
    }

    bool CanSeePlayer()
    {
        // Comprueba si el jugador está dentro del ángulo de visión del enemigo
        Vector3 directionToPlayer = player.position - transform.position;
        if (Vector3.Angle(transform.forward, directionToPlayer) < 45f)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, directionToPlayer, out hit))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
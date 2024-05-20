using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRange = 2f; // Rango de ataque del enemigo
    public Animator animator; // Referencia al Animator del enemigo
    public Transform player; // Referencia al transform del jugador

    void Update()
    {
        // Calcula la distancia entre el enemigo y el jugador
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Si el jugador está dentro del rango de ataque, activa la animación de ataque
        if (distanceToPlayer <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }
}
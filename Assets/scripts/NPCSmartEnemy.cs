using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;
using UnityEngine.AI;

namespace SanBlasNPC
{
    public class NPCSmartEnemy : MonoBehaviour
    {
        public string targetName;
        public float speed;
        public float followDistance;
        public float attackDistance;
        private Transform target;
        private Animator animator;
    

        void Start()
        {
            animator = GetComponentInChildren<Animator>();
            target = GameObject.FindGameObjectWithTag(targetName).transform;
        }

        void Update()
        {
            Physics.Raycast(transform.position, target.position - transform.position, out RaycastHit hitInfo);
            if (hitInfo.transform.name != targetName)
            {
                ActivateNavMeshEnemy();
            }
            else
            {
                MoveEnemy();
            }
        }
        private void MoveEnemy()
        {
            if (Vector3.Distance(target.position, transform.position) < attackDistance)
            {
                transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
                Attack();
            }
            else if (Vector3.Distance(target.position, transform.position) < followDistance)
            {
                transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
                Move();
            }
            else
            {
                Stop();
            }
        }
        private void Attack()
        {
            DeactivateNavMeshEnemy();
            animator.SetBool("Attacking", true);
            animator.SetBool("Walking", false);
        }
        private void Move()
        {
            DeactivateNavMeshEnemy();
            animator.SetBool("Attacking", false);
            animator.SetBool("Walking", true);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        private void Stop()
        {
            animator.SetBool("Attacking", false);
            animator.SetBool("Walking", false);
            ActivateNavMeshEnemy();
        }
        private void ActivateNavMeshEnemy()
        {
            GetComponent<NPCNavMeshAnimatorManager>().enabled = true;
            GetComponent<NPCPatrullajeManager>().enabled = true;
            GetComponent<NavMeshAgent>().enabled = true;
        }
        private void DeactivateNavMeshEnemy()
        {
            GetComponent<NPCNavMeshAnimatorManager>().enabled = false;
            GetComponent<NPCPatrullajeManager>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
        }
    }
}

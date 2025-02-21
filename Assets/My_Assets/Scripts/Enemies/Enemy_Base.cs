using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Base : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] Rigidbody2D rb;

    [Header("Configurables References")]
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] int hitPoints = 2;
    [SerializeField] int worth = 20;

    Transform target;
    int pathIndex = 0;
    bool isDestroyed = false;

    void Start()
    {
        target = LevelManager.main.path[pathIndex];
    }

    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;

            if (pathIndex == LevelManager.main.path.Length)
            {
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                return;
            }

            else
            {
                target = LevelManager.main.path[pathIndex];
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0 && !isDestroyed)
        {
            EnemySpawner.onEnemyDestroy.Invoke();

            LevelManager.main.IncreaseCredits(worth);
            isDestroyed = true;
            Destroy(gameObject);
        }
    }

}
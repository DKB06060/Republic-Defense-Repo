using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Base : MonoBehaviour
{
    [Header("Configurables References")]
    [SerializeField] float bulletSpeed = 5f;
    [SerializeField] Rigidbody2D rb;

    Transform target;
    Tower_Base towerScript;

    public int damage;

    private void Awake()
    {
        StartCoroutine(DestroyOffset());
    }

    public void SetTarget(Transform _target)
    {
        target = _target;
    }

    void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * bulletSpeed;

        if (!target)
        {
            return;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy_Base>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyOffset()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }
}
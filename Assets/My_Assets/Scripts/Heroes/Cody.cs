using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cody : MonoBehaviour
{
    [Header("Configurables References")]
    [SerializeField] float targetingRange = 5f;
    [SerializeField] float rotationSpeed = 15f;
    [SerializeField] float bulletsPerSecond = 1f;
    [SerializeField] public int damage = 1;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firingPoint;

    Transform target;
    float timeUntilFire;

    void Update()
    {
        if (target == null)
        {
            FindTarget();
            return;
        }

        RotateTowardsTarget();

        if (!CheckTargetDistance())
        {
            target = null;
        }
        else
        {
            timeUntilFire += Time.deltaTime;

            if (timeUntilFire >= 1f / bulletsPerSecond)
            {
                Shoot();
                timeUntilFire = 0f;
            }
        }
    }

    void Shoot()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, firingPoint.position, Quaternion.identity);
        Bullet_Base bulletScript = bulletObject.GetComponent<Bullet_Base>();
        bulletScript.SetTarget(target);
        bulletScript.damage = damage;
    }

    void FindTarget()
    {
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, targetingRange, (Vector2)transform.position, 0f, enemyMask);

        if (hits.Length > 0)
        {
            target = hits[0].transform;
        }
    }

    bool CheckTargetDistance()
    {
        return Vector2.Distance(target.position, transform.position) <= targetingRange;
    }

    void RotateTowardsTarget()
    {
        float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;

        Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle + 90));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, targetingRange);
    }
}
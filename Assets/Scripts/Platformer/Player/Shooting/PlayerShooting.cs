using System;
using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] [Tooltip("Enemy layer for raycast detect")]
    private LayerMask layerMask;

    [SerializeField] [Tooltip("Bullet explosion effect ")]
    private GameObject impactEffect;

    [SerializeField] [Tooltip("The gun laser vfx")]
    private LineRenderer blasterLine;
    
    [SerializeField]
    private Transform _firePoint;

    private float damage = 50f;

    public void SetFirePoint(Transform point)
    {
        _firePoint = point;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(_firePoint.position, _firePoint.right);
        if (hit)
        {
            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>();
            if (enemy)
            {
                enemy.TakeDamage(damage);
            }
            //Instantiate(impactEffect, hit.point, Quaternion.identity);
            
            blasterLine.SetPosition(0, _firePoint.position);
            blasterLine.SetPosition(1, hit.point);
        }
        else
        {
            blasterLine.SetPosition(0, _firePoint.position);
            blasterLine.SetPosition(1, _firePoint.position + _firePoint.right * 100);
        }

        blasterLine.enabled = true;

        yield return new WaitForSeconds(0.02f);
        
        blasterLine.enabled = false;
    }
}

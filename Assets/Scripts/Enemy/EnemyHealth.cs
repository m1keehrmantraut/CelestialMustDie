using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float health;

    public void TakeDamage(float value)
    {
        health -= value;
        DeathChecker();
    }

    private void DeathChecker()
    {
        if (health <= 0f)
        {
            //instantiate anything
            Destroy(gameObject);
        }
    }
}

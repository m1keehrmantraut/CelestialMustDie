using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health")] public int maxHealth = 100;
    private int currentHealth;
    [SerializeField] private HealthBar healthBar;

    //[SerializeField] private Animator _animator;
    
    
    void Start ()
    {
        UpdateMaxHealth();
    }

    public void TakeDamage (int damage)
    {
        
        //if (!_heroKnight.isBlock)
        //{
            //_animator.SetTrigger("Hurt");
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        //    _heroKnight.m_rolling = false;
        //    _heroKnight.isBlock = false;
        //}
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void UpdateMaxHealth()
    {
        currentHealth = maxHealth;  
        healthBar.SetMaxHealth(maxHealth);
    }
}

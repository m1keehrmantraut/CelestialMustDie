using System.Collections.Generic;
using UnityEngine;

public class WeaponFollow : MonoBehaviour
{
    [Header("Renderers")]
    [SerializeField] [Tooltip("The main renderer of the character")]
    private SpriteRenderer characterRenderer;

    [SerializeField]  
    private List<SpriteRenderer> flippingParts;
    
    [SerializeField] 
    private SpriteRenderer weaponRenderer;

    [Header("Following parts")]
    [SerializeField] 
    private GameObject weapon;

    [SerializeField]
    private Transform leftPoint;

    [SerializeField]
    private Transform rightPoint;

    private PlayerShooting _shooting;

    private bool _isRight;
    private void Start()
    {
        _shooting = gameObject.GetComponent<PlayerShooting>();
    }
    
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - weapon.transform.position;
        difference.Normalize();
        
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        weaponRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        
        foreach (SpriteRenderer charRenderer in flippingParts)
        {
            charRenderer.flipY = weaponRenderer.flipY;
        }
        ChangeFirePoint();
        
    }

    private void ChangeFirePoint()
    {
        _shooting.SetFirePoint(_isRight ? leftPoint : rightPoint);
    }
}

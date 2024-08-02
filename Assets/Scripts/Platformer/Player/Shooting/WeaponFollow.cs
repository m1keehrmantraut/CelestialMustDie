using UnityEngine;

public class WeaponFollow : MonoBehaviour
{
    [SerializeField] 
    private SpriteRenderer characterRenderer;

    [SerializeField] 
    private SpriteRenderer weaponRenderer;

    [SerializeField] 
    private GameObject weapon;

    [SerializeField]
    private Camera camera;

    void Update()
    {
        Vector3 difference = camera.ScreenToWorldPoint(Input.mousePosition) - weapon.transform.position;
        difference.Normalize();
        
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        weaponRenderer.flipY = Mathf.Abs(rotZ) > 90f;
    }
}

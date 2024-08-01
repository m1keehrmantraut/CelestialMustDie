using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private Transform FirePoint;
    [SerializeField] private GameObject Bullet;


    [SerializeField] private int speed;

    void Update()
    {
        Vector3 gunpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (gunpos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }  

        if (Input.GetMouseButtonDown(0))
        {

        }
    }

    private void Shoot(int a, bool d, GameObject siski)
    {
        siski.gameObject.SetActive(false);
    }

}
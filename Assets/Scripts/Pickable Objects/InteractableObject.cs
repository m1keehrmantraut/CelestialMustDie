using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private bool isActive;

    [SerializeField] private UnityEvent interactEvents;
    
    private GameObject info;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("e"))
        {
            InteractActions();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isActive)
        {
            Instantiate(info, gameObject.transform);
        }
    }

    private void InteractActions()
    {
        interactEvents.Invoke();
        Destroy(info);
    }
}

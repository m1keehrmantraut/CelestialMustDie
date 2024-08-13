using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private bool isActive;

    [SerializeField] private UnityEvent interactEvents;
    
    [SerializeField] private GameObject info;

    [SerializeField] private Transform infoPosition;

    [SerializeField] private Material outline;
    
    private GameObject tempInfo;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractActions();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isActive)
        {
            tempInfo = Instantiate(info, infoPosition);
            outline.SetFloat("_OutlineEnabled", true ? 1f : 0f);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isActive)
        {
            Destroy(tempInfo);
            outline.SetFloat("_OutlineEnabled", false ? 1f : 0f);
        }
    }

    private void InteractActions()
    {
        interactEvents.Invoke();
        Destroy(tempInfo);
        isActive = false;
        outline.SetFloat("_OutlineEnabled", false ? 1f : 0f);
    }
}

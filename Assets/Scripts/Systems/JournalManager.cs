using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalManager : MonoBehaviour
{
    [SerializeField] private GameObject journalPanel;
    
    public void JournalActivation(bool mode)
    {
        journalPanel.SetActive(mode);
    }
}

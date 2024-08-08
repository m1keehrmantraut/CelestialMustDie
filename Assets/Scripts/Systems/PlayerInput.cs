using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private JournalManager journal;

    private bool journalMode = false;

    private void Start()
    {
        journal = GameObject.FindWithTag("JournalManager").GetComponent<JournalManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !journalMode)
        {
            journal.JournalActivation(!journalMode);
            ChangeJournalMode(true);
        }
    }

    public void ChangeJournalMode(bool mode)
    {
        journalMode = mode;
    }
    
}

using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _movement;
    private PlayerShooting _shooting;
    
    private JournalManager _journal;

    private bool _journalMode = false;
    private bool _isMoving = true;

    private void Start()
    {
        _movement = gameObject.GetComponent<PlayerMovement>();
        _shooting = gameObject.GetComponent<PlayerShooting>();
        _journal = GameObject.FindWithTag("JournalManager").GetComponent<JournalManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !_journalMode)
        {
            Time.timeScale = 0;
            _journal.SetPage(_journal.tempIndex);
            _journal.JournalActivation(!_journalMode);
            ChangeJournalMode(true);
        }

        if (_isMoving)
        {
            _movement.MovementInput(Input.GetAxisRaw("Horizontal"));
        }
        
        if (Input.GetButtonDown("Jump") && _isMoving)
        {
            _movement.JumpEnabler();
        }

        if (Input.GetButtonDown("Fire1") && _isMoving)
        {
            _shooting.ShootingInput();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            CloseAllPanels();
        }
    }

    public void ChangeJournalMode(bool mode)
    {
        _journalMode = mode;
        _isMoving = !mode;
        Time.timeScale = 1;
    }

    private void CloseAllPanels()
    {
        _journal.JournalActivation(false);
        ChangeJournalMode(false);
    }
}

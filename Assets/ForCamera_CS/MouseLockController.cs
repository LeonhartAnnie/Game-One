using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLockController : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isMouseLocked = true;

    void Start()
    {
        LockMouse();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ToggleMouseLock();
        }
    }

    void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isMouseLocked = true;
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isMouseLocked = false;
    }

    void ToggleMouseLock()
    {
        if (isMouseLocked)
        {
            UnlockMouse();
        }
        else
        {
            LockMouse();
        }
    }
}

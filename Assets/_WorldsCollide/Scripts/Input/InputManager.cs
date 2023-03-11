using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public InputActions InputActions { get; private set; }
    private void Awake()
    {
        InputActions = new InputActions();
        InputActions.Enable();
        Cursor.visible = false;
    }
}
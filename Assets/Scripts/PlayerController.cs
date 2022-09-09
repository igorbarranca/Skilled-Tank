using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, PlayerInputActions.ITankActions
{
    PlayerInputActions playerInput;
    Rotator rotator;

    float rotationInputValue;

    private void Awake()
    {
        playerInput = new PlayerInputActions();
        playerInput.Tank.SetCallbacks(this);

        rotator = GetComponent<Rotator>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rotator.Rotate(rotationInputValue);
    }

    private void Update()
    {
        Debug.Log(rotationInputValue);
    }

    public void OnRotation(InputAction.CallbackContext context)
    {
        rotationInputValue = context.ReadValue<float>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
}

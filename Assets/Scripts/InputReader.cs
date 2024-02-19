using UnityEngine;

public class InputReader : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private Vector2 movementInput;
    private bool jumpInput;

    public Vector2 Movement
    {
        get { return movementInput; }
    }

    public bool Jump
    {
        get { return jumpInput; }
    }

    void Start()
{
    inputActions = new PlayerInputActions();
    inputActions.Enable();
}

void Update()
{
    movementInput = inputActions.PlayerControls.Move.ReadValue<Vector2>();
    jumpInput = inputActions.PlayerControls.Jump.triggered;
}

void OnDisable()
{
    inputActions.Disable();
}
}
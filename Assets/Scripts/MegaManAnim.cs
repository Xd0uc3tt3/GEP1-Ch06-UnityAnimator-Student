using UnityEngine;
using UnityEngine.InputSystem;

public class MegaManAnim : MonoBehaviour
{
    public Animator animController;
    public Vector2 movementInput;

    void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        animController.SetFloat("MoveInputX", movementInput.x);
    }
    
}

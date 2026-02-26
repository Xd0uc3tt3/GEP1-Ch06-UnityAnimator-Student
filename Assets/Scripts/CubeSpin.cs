using UnityEngine;
using UnityEngine.InputSystem;

public class CubeSpin : MonoBehaviour
{
    public Animator animator;

    private int IsRotatingHash = Animator.StringToHash("isRotating");


    public void ToggleSpin(InputAction.CallbackContext context)
    {
        if (context.performed && (animator.GetBool(IsRotatingHash) == true))
        {
            animator.SetBool(IsRotatingHash, false);
        }

        else if (context.performed && (animator.GetBool(IsRotatingHash) == false))
        {
            animator.SetBool(IsRotatingHash, true);
        }
    }
}

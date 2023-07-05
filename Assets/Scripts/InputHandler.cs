using UI_InputSystem.Base;
using UnityEngine;
using Zenject;

public class InputHandler : MonoBehaviour
{
    [Inject] private CharacterController characterController;

    private void Update()
    {
        float moveHorizontal = UIInputSystem.ME.GetAxisHorizontal(JoyStickAction.Movement); 
        float moveVertical = UIInputSystem.ME.GetAxisVertical(JoyStickAction.Movement);
        if (moveHorizontal == 0) moveHorizontal = Input.GetAxis("Horizontal");
        if (moveVertical == 0) moveVertical = Input.GetAxis("Vertical"); 

        characterController.Move(moveVertical, moveHorizontal);
    }
}

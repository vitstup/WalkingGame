using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator controller;

    public void SetMovementAnimation(float movementSpeed)
    {
        controller.SetFloat("Vertical", movementSpeed);
    }
}

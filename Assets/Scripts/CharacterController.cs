using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private AnimationController controller;

    public void Move(float moveDirection, float rotationDirection)
    {
        Vector3 movement = new Vector3(moveDirection, 0f, 0f);
        movement.Normalize();
        movement *= movementSpeed * Time.deltaTime * Mathf.Abs(moveDirection);
        transform.Translate(movement, Space.Self);

        if (moveDirection != 0f)
        {
            Quaternion rotation = Quaternion.Euler(0f, rotationDirection, 0f);
            transform.rotation *= rotation * Quaternion.Euler(0f, rotationSpeed * Time.deltaTime, 0f);
        }

        float movementAnimation = Mathf.Clamp(Mathf.Abs(moveDirection), 0, 1f);
        controller.SetMovementAnimation(movementAnimation);
    }


}
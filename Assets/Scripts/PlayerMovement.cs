using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Input input;
    [SerializeField] float speed;
    void Awake()
    {
        input = new Input();
        input.Player.Enable();
    }
    void FixedUpdate()
    {
        Vector2 inputVector = input.Player.Move.ReadValue<Vector2>();
        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y, 0f);
        transform.position += moveDir * speed * Time.deltaTime;
    }
}

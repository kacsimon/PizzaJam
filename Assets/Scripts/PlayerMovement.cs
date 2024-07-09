using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerInput input;
    [SerializeField] float speed;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Input input = new Input();
        input.Player.Enable();
        input.Player.Move.performed += Input_Move;
    }
    void Input_Move(InputAction.CallbackContext obj)
    {
        Vector2 inputValue = obj.ReadValue<Vector2>();
        rb.AddForce(new Vector2(inputValue.x, inputValue.y) * speed * Time.deltaTime, ForceMode2D.Force);
    }
}

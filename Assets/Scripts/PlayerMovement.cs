using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput input;
    [SerializeField] int speed;
    void Awake()
    {
        input = GetComponent<PlayerInput>();
    }
}

using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    Input input;
    GameObject playerVisual;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite newSprite;
    void Awake()
    {
        playerVisual = transform.GetChild(0).gameObject;
        spriteRenderer = playerVisual.GetComponent<SpriteRenderer>();
        Debug.Log(playerVisual.name);
        input = new Input();
        input.Player.Enable();
        input.Player.Interact.performed += Interact_performed;
    }
    void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (GameManager.Instance.GetPossess())
        {
            GameManager.Instance.IncreasePossesLevel(1);
            Debug.Log("ToDo: Destroy Possesed.GameObject");
            spriteRenderer.sprite = newSprite;
        }
    }
}

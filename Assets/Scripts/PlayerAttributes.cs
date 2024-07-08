using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("Collided.");
        }
    }
}

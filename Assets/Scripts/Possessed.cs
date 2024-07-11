using UnityEngine;

public class Possessed : MonoBehaviour
{
    [SerializeField] GameObject visual;
    [SerializeField] GameObject selectedVisual;
    [SerializeField] int level;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            selectedVisual.SetActive(true);
            if (GameManager.Instance.GetPossessLevel() == level) GameManager.Instance.SetPossess(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            selectedVisual.SetActive(false);
            GameManager.Instance.SetPossess(false);
            if (GameManager.Instance.GetPossessLevel() > level) Destroy(gameObject);
        }
    }
}

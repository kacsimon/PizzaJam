using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    int possessLevel = 1;
    bool canPossess;

    void Awake()
    {
        #region Singleton
        if (Instance != null && Instance != this) Destroy(this);
        else
        {
            Instance = this;
            //DontDestroyOnLoad(this);
        }
        #endregion
    }
    public void SetPossess(bool _value)
    {
        canPossess = _value;
    }
    public bool GetPossess() { return canPossess; }
    public int GetPossessLevel() { return possessLevel; }
    public void IncreasePossesLevel(int value)
    {
        possessLevel += value;
    }
}
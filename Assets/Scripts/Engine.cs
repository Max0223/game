using UnityEngine;

public abstract class Engine : MonoBehaviour
{
    public abstract bool TryMove();
    public abstract float Spend();
    public abstract float GetSpeed { get; }
}

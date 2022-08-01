using UnityEngine;

public abstract class Engine : MonoBehaviour
{
    public abstract float Speed { get; }
    public abstract bool TryMove();
}

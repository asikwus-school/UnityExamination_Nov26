using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnStart : MonoBehaviour
{
    public UnityEvent onStart;

    public void Start() => onStart?.Invoke();
}

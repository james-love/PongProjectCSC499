using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField] private UnityEvent goalHit;

    private void OnCollisionEnter2D(Collision2D c)
    {
        goalHit.Invoke();
    }
}

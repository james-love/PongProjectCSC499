using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField] private UnityEvent goalHit;
    [SerializeField] private ParticleSystem goalParticles;

    private void OnCollisionEnter2D(Collision2D c)
    {
        goalParticles.Stop();
        goalParticles.Play();
        goalHit.Invoke();
    }
}

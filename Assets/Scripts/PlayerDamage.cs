using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public HealthManager healthManager; // Reference to your HealthManager object
    public string damageTag = "Enemy";  // Tag of the object that causes damage

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(damageTag))
        {
            healthManager.RemoveHeart(); // Call method in HealthManager to remove a heart
        }
    }
}
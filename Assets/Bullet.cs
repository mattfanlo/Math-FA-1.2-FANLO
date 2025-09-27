using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;

    void Awake()
    {
        Destroy(gameObject, life); // destroy after some time
    }

    void OnCollisionEnter(Collision collision)
    {
        // Example: only destroy enemies
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject); // always destroy the bullet
    }
}

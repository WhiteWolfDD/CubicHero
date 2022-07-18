using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class Enemy : MonoBehaviour
    {
        // public float _damage;
        
        // private Rigidbody _rigidbody;
        
        // private void Start()
        // {
            // _rigidbody = GetComponent<Rigidbody>();
        // }

        // private void OnCollisionEnter(Collision collision)
        // {
            // var contact = collision.contacts[0];

            // if (collision.gameObject.TryGetComponent(out Player.Player player))
            // {
                // Die(contact.point);
            // }
        // }

        // private void Die(Vector3 position)
        // {
            // var explosion = Instantiate(Resources.Load<GameObject>("Prefabs/Enemy/Explosion"), position,
            // Quaternion.identity);
            // Destroy(explosion, 1f);
            
            // Destroy(gameObject);
        // }
    }
}
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] public float normalSpeed = 5f;
        [SerializeField] public float maxSpeed = 10f;
        
        private int _damage = 10;
        
        private const int Health = 100;
        private int _currentHealth;

        // public event UnityAction PlayerDied;
        // public event UnityAction<Vector3> PlayerHitted;

        private void Start()
        {
            _currentHealth = Health;
        }

        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            
            if (_currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            // PlayerDied?.Invoke();
            
            Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision collision)
        {
            var collisionDirection = collision.GetContact(0).normal;

            if (!collision.gameObject.TryGetComponent(out Enemy.Enemy enemy)) return;
            
            if (Mathf.Abs(collisionDirection.z) >= 0.95f)
            {
                Die();
            }

            // PlayerHitted?.Invoke(collisionDirection);
            
            TakeDamage(_damage);
        }
    }
}
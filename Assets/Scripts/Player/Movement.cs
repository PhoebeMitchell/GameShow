using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Rigidbody2D _rigidbody2D;

        public Vector2 Direction
        {
            set => _rigidbody2D.velocity = value.normalized * _speed;
        }

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
    }
}

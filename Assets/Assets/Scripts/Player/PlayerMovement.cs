using System;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] public float minimalSwipeLength = 10f;
        
        private Transform _player;
        private Player _playerController;

        private int _currentLineIndex = 2;
        private bool _canChangeLine = true;

        private Vector2 _startSwipePosition;
        private Vector2 _endSwipePosition;

        private void Awake()
        {
            _playerController = GetComponent<Player>();
        }

        private void Update()
        {
            MoveForward();
            
            if (Input.touchCount <= 0) return;
            
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved && _canChangeLine)
            {
                _endSwipePosition = touch.position;

                float swipeLength = Vector2.Distance(_startSwipePosition, _endSwipePosition);
                if (!(swipeLength > minimalSwipeLength)) return;
                
                Vector2 swipeDirection = _endSwipePosition - _startSwipePosition;
                swipeDirection.Normalize();

                if (swipeDirection.x > 0)
                {
                    MoveRight();
                }
                else
                {
                    MoveLeft();
                }

                _canChangeLine = false;
            }
            else if (touch.phase == TouchPhase.Began)
            {
                _startSwipePosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                _canChangeLine = true;
            }
        }

        private void MoveForward()
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * _playerController.normalSpeed));
        }
        
        private void MoveLeft()
        {
            if (_currentLineIndex == 1) return;
            
            _currentLineIndex--;
            transform.position = new Vector3(transform.position.x - 3, transform.position.y, transform.position.z);
        }

        private void MoveRight()
        {
            if (_currentLineIndex == 3) return;
            
            _currentLineIndex++;
            transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
        }
    }
}
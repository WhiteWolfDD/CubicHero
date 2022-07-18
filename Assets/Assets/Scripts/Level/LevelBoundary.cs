using System;
using UnityEngine;

namespace Assets.Scripts.Level
{
    public class LevelBoundary : MonoBehaviour
    {
        [SerializeField] public float leftSide = -4.5f;
        [SerializeField] public float rightSide = 4.5f;
        private float _internalLeft;
        private float _internalRight;
        
        private void Update()
        {
            _internalLeft = leftSide;
            _internalRight = rightSide;
        }
    }
}

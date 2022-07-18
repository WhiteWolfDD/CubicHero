using System;
using Assets.Scripts.Game;
using UnityEngine;

namespace Assets.Scripts.Camera
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] public Transform trackedObject;
        [SerializeField] public float updateSpeed = 5;
        [SerializeField] public Vector3 trackingOffset;
        
        private Vector3 _offset;
        
        private void Start()
        {
            _offset = trackingOffset;
            _offset.z = transform.position.z - trackedObject.position.z;
        }

        private void LateUpdate()
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(_offset.x, _offset.y, trackedObject.position.z + _offset.z), updateSpeed * Time.deltaTime);
        }
    }
}
using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

namespace Game.Models.Camera.Impl
{
    public class CameraHolder : ICameraHolder
    {
        private Transform _follow;
        private Transform _lookAt;
        private CinemachineBrain _brain;
        private UnityEngine.Camera _mainCamera;
        
        private IReadOnlyDictionary<ECameraType, CinemachineVirtualCamera> _cameras;
        
        public Transform LookAt
        {
            get => _lookAt;
            set
            {
                _lookAt = value;
                SetLookAtTarget(_lookAt);
            }
        }

        public Transform Follow
        {
            get => _follow;
            set
            {
                _follow = value;
                SetFollowTarget(_follow);
            }
        }

        public UnityEngine.Camera Camera
        {
            get => _mainCamera;
            set
            {
                if (_mainCamera == null)
                {
                    _mainCamera = value;
                }
            }
        }

        public void SetActiveCamera(ECameraType cameraType)
        {
            foreach (var (type, camera) in _cameras)
            {
                camera.gameObject.SetActive(type == cameraType);
            }
        }

        public void DeactivateAllCameras()
        {
            foreach (var (_, camera) in _cameras)
            {
                camera.gameObject.SetActive(false);
            }
        }

        public CinemachineVirtualCamera GetCamera(ECameraType cameraType)
        {
            foreach (var (type, camera) in _cameras)
            {
                if (type == cameraType)
                    return camera;
            }

            throw new Exception($"Cannot find camera with type: {cameraType}");
        }

        public void SetBrain(CinemachineBrain brain)
        {
            _brain = brain;
        }

        public Vector3 GetScreenToWorldMousePosition(Vector3 screenMousePosition)
        {
            var ray = Camera.ScreenPointToRay(screenMousePosition);
            var raycastHit = new RaycastHit[1];

            if (Physics.RaycastNonAlloc(ray, raycastHit, float.MaxValue, 1 << 3) > 0)
            {
                return raycastHit[0].point;
            }
            
            return Vector3.zero;
        }

        public void Init(IReadOnlyDictionary<ECameraType, CinemachineVirtualCamera> cameras)
        {
            _cameras = cameras;
            SetFollowTarget(_follow);
            SetLookAtTarget(_lookAt);
        }
        
        public void Update()
        {
            if (_brain == null)
                return;

            _brain.ManualUpdate();
        }
        
        private void SetFollowTarget(Transform follow)
        {
            foreach (var camera in _cameras.Values)
            {
                camera.Follow = follow;
            }
        }

        private void SetLookAtTarget(Transform lookAt)
        {
            foreach  (var camera in _cameras.Values)
            {
                camera.LookAt = lookAt;
            }
        }
    }
}
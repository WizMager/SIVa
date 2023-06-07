using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

namespace Game.Models.Camera
{
    public interface ICameraHolder
    {
        public Transform LookAt { get; set; }
        public Transform Follow { get; set; }
        public UnityEngine.Camera Camera {get;}
        
        void SetActiveCamera(ECameraType cameraType);
        void DeactivateAllCameras();
        CinemachineVirtualCamera GetCamera(ECameraType cameraType);
        public void SetBrain(CinemachineBrain brain);
        public Vector3 GetScreenToWorldMousePosition(Vector3 screenMousePosition);
        void Init(IReadOnlyDictionary<ECameraType, CinemachineVirtualCamera> cameras);
        void Update();
    }
}
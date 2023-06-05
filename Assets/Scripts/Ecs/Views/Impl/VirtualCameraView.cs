using System;
using System.Collections.Generic;
using Cinemachine;
using Game.Models.Camera;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Views.Impl
{
    public class VirtualCameraView : ObjectView
    {
        [SerializeField] private List<CameraTypeHolder> cameras;

        [Inject] private ICameraHolder _cameraHolder;

        public override void Link(IEntity entity, IContext context)
        {
            base.Link(entity, context);
            
            var camerasDictionary = new Dictionary<ECameraType, CinemachineVirtualCamera>();
            
            foreach (var cameraTypeHolder in cameras)
            {
                camerasDictionary[cameraTypeHolder.cameraType] = cameraTypeHolder.virtualCamera;
            }
            
            _cameraHolder.Init(camerasDictionary);
        }
		
        [Serializable]
        private struct CameraTypeHolder
        {
            public ECameraType cameraType;
            public CinemachineVirtualCamera virtualCamera;
        }
    }
}
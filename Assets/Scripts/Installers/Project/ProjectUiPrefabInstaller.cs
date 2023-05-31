using UnityEngine;
using Zenject;

namespace Installers.Project
{
    [CreateAssetMenu(menuName = "Installers/ProjectUiPrefabsInstaller", fileName = "ProjectUiPrefabsInstaller")]
    public class ProjectUiPrefabInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas projectCanvas;
        
        public override void InstallBindings()
        {
            var canvasView = Container.InstantiatePrefabForComponent<Canvas>(projectCanvas);
            var canvasTransform = canvasView.transform;
        }
    }
}
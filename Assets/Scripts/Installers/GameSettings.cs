using Game.Db.PrefabBase;
using Game.Db.PrefabBase.Impl;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class GameSettings : MonoInstaller
    {
        [SerializeField] private PrefabBase prefabBase;
        
        public override void InstallBindings()
        {
            Container.Bind<IPrefabBase>().FromInstance(prefabBase);
        }
    }
}
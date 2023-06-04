using Game.Db.PlayerParameters;
using Game.Db.PlayerParameters.Impl;
using Game.Db.PrefabBase;
using Game.Db.PrefabBase.Impl;
using UnityEngine;
using Zenject;

namespace Installers.Game
{
    [CreateAssetMenu(menuName = "Installers/GameSettings", fileName = "GameSettings")]
    public class GameSettings : ScriptableObjectInstaller
    {
        [SerializeField] private PrefabBase prefabBase;
        [SerializeField] private PlayerParameters playerParameters;
        
        public override void InstallBindings()
        {
            Container.Bind<IPrefabBase>().FromInstance(prefabBase).AsSingle();
            Container.Bind<IPlayerParameters>().FromInstance(playerParameters).AsSingle();
        }
    }
}
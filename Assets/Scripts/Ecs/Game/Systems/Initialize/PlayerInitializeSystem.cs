using Assets.Scripts.Game.Utils;
using Ecs.Game.Extensions;
using Ecs.Utils.Parameters;
using Ecs.Views.Impl;
using Game.Db.PlayerParameters;
using Game.Db.PrefabBase;
using Game.Providers.GameFieldProvider;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems.Initialize
{
    public class PlayerInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly IPrefabBase _prefabBase;
        private readonly IGameEnvironmentProvider _gameEnvironmentProvider;
        private readonly DiContainer _diContainer;
        private readonly IPlayerParameters _playerParameters;

        public PlayerInitializeSystem(
            GameContext game,
            IPrefabBase prefabBase,
            IGameEnvironmentProvider gameEnvironmentProvider,
            DiContainer diContainer,
            IPlayerParameters playerParameters
            )
        {
            _game = game;
            _prefabBase = prefabBase;
            _gameEnvironmentProvider = gameEnvironmentProvider;
            _diContainer = diContainer;
            _playerParameters = playerParameters;
        }
        
        public void Initialize()
        {
            var gameEnvironment = _gameEnvironmentProvider.GameEnvironment;
            var playerSpawnPoint = gameEnvironment.PlayerSpawnPoint;

            CreatePlayer(playerSpawnPoint);
        }

        private void CreatePlayer(Transform playerSpawnPoint)
        {
            var playerView = Object.Instantiate(_prefabBase.GetPrefabWithName("Player"))
                .GetComponent<PlayerView>();
            _diContainer.Inject(playerView);

            var player =  _game.CreatePlayer(playerView, playerSpawnPoint);
            AddParameters(EUnitClass.warrior ,player);
        }

        private void AddParameters(EUnitClass eUnitClass, GameEntity player)
        {
            var parameters = _playerParameters.GetParametersByType(eUnitClass);

            foreach (var parameter in parameters.parameters)
            {
                switch (parameter.parameter)
                {
                    case EParameters.Armor:
                        player.AddArmor(parameter.value);
                        break;
                    case EParameters.CritRate:
                        player.AddCritRate(parameter.value);
                        break;
                    case EParameters.Dexterity:
                        player.AddDexterity(parameter.value);
                        break;
                    case EParameters.EnergyRecovery:
                        player.AddEnergyRecovery(parameter.value);
                        break;
                    case EParameters.HealthRecovery:
                        player.AddHealthRecovery(parameter.value);
                        break;
                    case EParameters.Power:
                        player.AddPower(parameter.value);
                        break;
                    case EParameters.MoveSpeed:
                        player.AddMoveSpeed(parameter.value);
                        break;
                    case EParameters.Wisdom:
                        player.AddWisdom(parameter.value);
                        break;
                    case EParameters.Health:
                        player.AddHealth(parameter.value, parameter.value);
                        break;
                    case EParameters.Mana:
                        player.AddMana(parameter.value, parameter.value);
                        break;
                    case EParameters.UltimateEnergy:
                        player.AddUltimateEnergy(parameter.value, parameter.value);
                        break;
                }
            }
        }
    }
}
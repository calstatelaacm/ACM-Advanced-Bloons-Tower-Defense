using UnityEngine;

namespace TMG.BloonsTD.Gameplay
{
    public class TowerUpgradeController : MonoBehaviour
    {
        public TowerUpgrade[] Upgrades => _upgrades;
        private TowerUpgrade[] _upgrades = new TowerUpgrade[3];

        public void InitializeUpgrades(TowerController controller)
        {
            var towerProperties = controller.TowerProperties;
            _upgrades[0] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradePropertiesPath1);
            _upgrades[1] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradePropertiesPath2);
            _upgrades[2] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradePropertiesPath3);
        }
    }
}
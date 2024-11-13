using Data.Matching;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField] private PlayerName _nameLabel;
    
    [SerializeField] private PlayerLevel _levelLabel;
    
    [SerializeField] private PlayerExp _experienceLabel;
    
    [SerializeField] private PlayerExpBar _experienceProgressBar;
    
    [SerializeField] private AchievementsContentManager _achievementsContentManager;

    [SerializeField] private ToggleButtonsManager _toggleButtonsManager;

    [SerializeField] private MatchStatsContentManager _matchStatsContentManager;

    public override void InstallBindings()
    {
        Container.Bind<PlayerName>().FromInstance(_nameLabel);
        Container.Bind<PlayerLevel>().FromInstance(_levelLabel);
        Container.Bind<PlayerExp>().FromInstance(_experienceLabel);
        Container.Bind<PlayerExpBar>().FromInstance(_experienceProgressBar);
        Container.Bind<AchievementsContentManager>().FromInstance(_achievementsContentManager);
        Container.Bind<ToggleButtonsManager>().FromInstance(_toggleButtonsManager);
        Container.Bind<MatchStatsContentManager>().FromInstance(_matchStatsContentManager);
    }
}
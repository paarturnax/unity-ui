using Data.Matching;
using Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using Newtonsoft.Json.Linq;
using Zenject;

namespace Modules.Profile.View
{
	public class ProfileView : MonoBehaviour
	{
        [Inject]
        [SerializeField] private PlayerName _nameLabel;
        [Inject]
        [SerializeField] private PlayerLevel _levelLabel;
        [Inject]
        [SerializeField] private PlayerExp _experienceLabel;
        [Inject]
        [SerializeField] private PlayerExpBar _experienceProgressBar;
        [Inject]
        [SerializeField] private AchievementsContentManager _achievementsContentManager;
        [Inject]
        [SerializeField] private MatchStatsContentManager _matchStatsContentManager;


        //[HideInInspector] public AccountData AccountData;

        //  public string Name;
        //  public string AvatarIcon;
        //  public int Level;
        //  public int Experience;
        //  public int ExperienceMax;
        //  public AchievementData[] Achievements;
        //  public MatchData[] Matches;

        public void InitializeUI(AccountData accountData)
        {
            _nameLabel.text = accountData.Name;
            _levelLabel.text = $"LEVEL {accountData.Level}:";
            _experienceLabel.text = $"{accountData.Experience} / {accountData.ExperienceMax}";
            _experienceProgressBar.value = (float)accountData.Experience / (float)accountData.ExperienceMax;
            _achievementsContentManager.dataArray = accountData.Achievements;
            _matchStatsContentManager.matchDataArray = accountData.Matches;
        }
    }
}
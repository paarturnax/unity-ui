using Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AchievementsContentManager : MonoBehaviour
{
    [SerializeField] private Achievement _achievement;
    [SerializeField] private AchievementsBar _achievementsBar;
    public AchievementData[] dataArray;
    [SerializeField] private Queue<AchievementsBar> bars;


    private void OnEnable()
    {
        bars = new Queue<AchievementsBar>();

        foreach (var item in dataArray)
        {
            if (bars.Count != 0 && bars.Last().AchivementsCount < 2)
            {
                bars.Last().AchivementsCount++;
            }
            else
            {
                AchievementsBar newBar = Instantiate(_achievementsBar, transform);
                bars.Enqueue(newBar);
            }
            AddAchievemntOnLayout(item, bars.Last());
        }
    }

    public void AddAchievemntOnLayout(AchievementData data, AchievementsBar parrent)
    {
        Achievement achievement = Instantiate(_achievement, parrent.transform);
        achievement.transform.SetParent(parrent.transform, true);
        achievement.Initialize(data);
    }
}

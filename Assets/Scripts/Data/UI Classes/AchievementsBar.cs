using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementsBar : MonoBehaviour
{
    //[SerializeField] public List<Achievement> _achievements = new List<Achievement>(3);
    public int AchivementsCount;

    private void OnEnable()
    {
        AchivementsCount = 0;
    }

    private void OnDisable()
    {
        Destroy(gameObject);
    }
}


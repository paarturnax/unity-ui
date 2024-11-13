using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Matching
{
    public class StatsInputer : MonoBehaviour
    {
        [SerializeField] private StatContainer _container1;
        [SerializeField] private StatContainer _container2;
        [SerializeField] private StatContainer _container3;

        public void InitializeStatContainers(MatchData data)
        {
            _container1.InitializeContainer(data.Parameters[0]);
            _container2.InitializeContainer(data.Parameters[1]);
            _container3.InitializeContainer(data.Parameters[2]);
        }
    }
}

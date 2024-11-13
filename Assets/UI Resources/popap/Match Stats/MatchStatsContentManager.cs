
using UnityEngine;

namespace Data.Matching
{
    public class MatchStatsContentManager : MonoBehaviour
    {
        public MatchData[] matchDataArray;

        [SerializeField] private MatchToggleButton button1;
        [SerializeField] private MatchToggleButton button2;
        [SerializeField] private MatchToggleButton button3;

        private void OnEnable()
        {
            button1.ConcreteMatchData = matchDataArray[2];
            button2.ConcreteMatchData = matchDataArray[1];
            button3.ConcreteMatchData = matchDataArray[0];
        }

    }
}

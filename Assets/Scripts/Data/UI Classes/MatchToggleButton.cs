using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;
using UnityEngine.UI;

namespace Data.Matching
{
    public class MatchToggleButton : MonoBehaviour
    {
        public Toggle Toggle;
        
        public MatchData ConcreteMatchData;
        [SerializeField] private StatsInputer _stats;

        [Inject]
        [SerializeField] private ToggleButtonsManager _toggleListener;

        private void OnEnable()
        {
            _toggleListener.MatchToggleHasChanged += onToggleHasChanged;
        }


        private void onToggleHasChanged(Toggle toggle)
        {
            Toggle.isOn = Toggle == toggle;
        }

        public void OnToggle()
        {
            _stats.gameObject.SetActive(Toggle.isOn);
            if (Toggle.isOn)
            {
                _stats.InitializeStatContainers(ConcreteMatchData);
                _toggleListener.InvokeMatchToggleChanged(Toggle);
            }
            
        }

        private void OnDisable()
        {
            _toggleListener.MatchToggleHasChanged -= onToggleHasChanged;
        }
    }
}

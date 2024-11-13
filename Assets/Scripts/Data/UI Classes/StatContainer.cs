using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Data.Matching
{
    public class StatContainer : MonoBehaviour
    {
        public MatchParameter Parametrs;

        [SerializeField] private TMP_Text Header;
        [SerializeField] private TMP_Text SubHeader;
        [SerializeField] private TMP_Text Score;

        public void InitializeContainer(MatchParameter parameters)
        {
            Header.text = parameters.Header;
            SubHeader.text = parameters.SubHeader;
            Score.text = Convert.ToString(parameters.Score);
        }
    }
}

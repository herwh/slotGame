using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class WinlineData
    {
        [SerializeField] private List<int> _winline;
        [SerializeField] private int _reward;

        public List<int> Winline => _winline;
        public int Reward => _reward;
    }
}
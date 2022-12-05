using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class WinlineData
    {
        [SerializeField] private List<int> _winline;

        public List<int> Winline => _winline;
    }
}
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "New WinlinesConfig", menuName = "WinlinesConfig", order = 0)]
    public class WinlinesConfig : ScriptableObject
    {
        [SerializeField] private List<WinlineData> _winlineData;
        public List<WinlineData> WinlineData => _winlineData;
    }
}
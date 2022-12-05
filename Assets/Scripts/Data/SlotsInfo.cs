using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "New SlotsInfo", menuName = "SlotsInfo", order = 0)]
    public class SlotsInfo : ScriptableObject
    {
        [SerializeField] private List<SlotData> _slotData;

        public List<SlotData> SlotData => _slotData;
    }
}
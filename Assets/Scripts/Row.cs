using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Row : MonoBehaviour
    {
        [SerializeField] private SlotsInfo _slots;
        public List<SlotData> SlotValues => _slotValues;

        private List<SlotData> _currentSlots=new (); 
        private List<SlotData> _slotValues; 

        private void Create()
        {
            for (int i = 0; i < _slots.SlotData.Count; i++)
            {
                
            }
        }
        
        private List<SlotData> Spin()
        {
            return null;
        }
    }
}
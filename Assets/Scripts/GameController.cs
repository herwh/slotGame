using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private WinlinesConfig _config;

        private int _reward;
        private List<List<SlotData>> _rows; 

        private void SpinRows()
        {
            
        }

        private void CheckWinlines()
        {
            for (int i = 0; i < _config.WinlineData.Count; i++)
            {
                if (CheckWinline(_config.WinlineData[i]))
                {
                    _reward += _config.WinlineData[i].Reward;
                }
            }
        }

        private bool CheckWinline(WinlineData data) 
        {
            var firstSlot = _rows[0][data.Winline[0]];
            
            for (int i = 1; i < data.Winline.Count; i++)
            {
                if (firstSlot.SpriteValue != _rows[i][data.Winline[i]].SpriteValue)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
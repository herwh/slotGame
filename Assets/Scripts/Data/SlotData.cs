using System;
using UnityEngine;

[Serializable]
public class SlotData
{
    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _spriteValue;

    public Sprite Sprite => _sprite;
    public string SpriteValue => _spriteValue;
}

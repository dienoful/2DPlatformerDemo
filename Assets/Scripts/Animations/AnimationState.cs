﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Animations
{
    [Serializable]
    public class AnimationState
    {
        public string Name;
        public bool IsLoop;
        public bool IsPlayNext;
        public Sprite[] Sprites;
        public UnityEvent OnComplete;
    }
}

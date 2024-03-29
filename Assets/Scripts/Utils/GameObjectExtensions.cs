﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public static class GameObjectExtensions
    {
        public static bool IsInLayer(this GameObject go, LayerMask layerMask)
        {
            return layerMask == (layerMask | 1 << go.layer);
        }
    }
}
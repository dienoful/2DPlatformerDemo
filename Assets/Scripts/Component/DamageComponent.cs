﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace WhereIAm.Scripts.Component
{
    public class DamageComponent : MonoBehaviour
    {
        [SerializeField] private int _damage;

        public void ApplyDamage(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();
            if (healthComponent != null)
            {
                healthComponent.ApplyDamage(_damage);
            }
        }
    }
}
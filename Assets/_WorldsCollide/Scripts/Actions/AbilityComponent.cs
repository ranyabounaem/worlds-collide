using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityComponent : MonoBehaviour
{
    List<Ability> _abilities = new List<Ability>();
    CooldownManager _cooldownManager;

    public void UseAbility(Ability ability)
    {
        foreach (var __ability in _abilities)
        {
            if (__ability == ability && _cooldownManager.AbilityOnCooldown(ability) == -1f)
            {
                ability.Use();
                _cooldownManager.AddCooldown(ability);
            }
        }
    }

    public void UseAbility(int index)
    {

        _abilities[index].Use();
    }
}
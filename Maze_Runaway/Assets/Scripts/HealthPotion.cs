using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Health Potion", menuName = "Inventory/Potion")]
public class HealthPotion : Item
{
    public float healthModifier;
    PlayerController playerController;

    private void Awake()
    {
        playerController = PlayerController.instance;
    }
    public override void Use()
    {
        base.Use();
        ApplyEffect();
    }

    public void ApplyEffect()
    {
        PlayerController.instance.HealthBarIncrease(healthModifier);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemProperties : MonoBehaviour {
	public StatsWindowScriptableObject itemProperties;
	public ItemStats itemData;

	// public Color rarityBackground;
	// public string itemName;
	// public string itemType;
	// public string itemRarity;
	
	// public string levelText;
	// public float itemLevel;
	// public float damageDefensePoints;
	// public string damageDefenseText;

	// public string itemAttributeText1, itemAttributeText2;
	// public float itemAttribute1, itemAttribute2;

	// public string[] stats;

	// public string itemLore;

	void Update() {
		itemData.rarityBackground = itemProperties.itemStats.rarityBackground;
		itemData.itemName = itemProperties.itemStats.itemName;
		itemData.itemType = itemProperties.itemStats.itemType;
		itemData.itemRarity = itemProperties.itemStats.itemRarity;

		itemData.itemLevel = itemProperties.itemStats.itemLevel;
		itemData.damageDefensePoints = itemProperties.itemStats.damageDefensePoints;
		itemData.damageDefenseText = itemProperties.itemStats.damageDefenseText;
		
		itemData.itemAttribute1 = itemProperties.itemStats.itemAttribute1;
		itemData.itemAttribute2 = itemProperties.itemStats.itemAttribute2;

		itemData.elementalDamage = itemProperties.itemStats.elementalDamage;
		itemData.critChance = itemProperties.itemStats.critChance;
		itemData.critDamage = itemProperties.itemStats.critDamage;
		itemData.areaOfEffect = itemProperties.itemStats.areaOfEffect;
		itemData.expGained = itemProperties.itemStats.expGained;
		itemData.weaponValue = itemProperties.itemStats.weaponValue;

		itemData.elementalResistance = itemProperties.itemStats.elementalResistance;
		itemData.elementalBoost = itemProperties.itemStats.elementalBoost;
		itemData.critBoost = itemProperties.itemStats.critBoost;
		itemData.strength = itemProperties.itemStats.strength;
		itemData.goldGained = itemProperties.itemStats.goldGained;
		itemData.armorValue = itemProperties.itemStats.armorValue;

		itemData.itemLore = itemProperties.itemStats.itemLore;
	}	

}

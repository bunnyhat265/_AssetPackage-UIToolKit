using System.Collections;
using UnityEngine;

[System.Serializable]
public class ItemStats {
	public Color rarityBackground;
	public string itemName;
	public string itemType;
	public string itemRarity;

	public int itemLevel;
	
	public int damageDefensePoints;
	public string damageDefenseText;

	public float itemAttribute1, itemAttribute2;

	[Header("Weapon Stats")]
	public float elementalDamage;
	public float critChance;
	public float critDamage;
	public float areaOfEffect;
	public float expGained;
	public float weaponValue;

	[Header("Armor Stats")]
	public float elementalResistance;
	public float elementalBoost;
	public float critBoost;
	public float strength;
	public float goldGained;
	public float armorValue;

	public string itemLore;
}

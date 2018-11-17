using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemInfoPanel : MonoBehaviour {

	public StatsWindowScriptableObject item;
	
	public Image rarityBG;
	public TextMeshProUGUI itemName;
	public TextMeshProUGUI itemType;
	public TextMeshProUGUI itemRarity;
	public TextMeshProUGUI itemLevel;

	public TextMeshProUGUI damageDefensePoints, damageDefenseText;

	public TextMeshProUGUI itemAttr1, itemAttr2;

	public TextMeshProUGUI[] stats;
	public TextMeshProUGUI lore;

	ItemProperties m_itemProperties;

	void Update() {
		rarityBG.color = item.itemStats.rarityBackground;
		itemName.text = item.itemStats.itemName;
		itemType.text = item.itemStats.itemType;
		itemRarity.text = item.itemStats.itemRarity;
	}

}

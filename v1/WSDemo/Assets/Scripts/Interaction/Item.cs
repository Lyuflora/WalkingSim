﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject
{
	public bool requiredItem;

	public bool grabbable;

	public AudioClip audioClip;
	public string itemName;
	public Sprite image;

	public bool rollableItem;	// **important

	[Header("Inventory")]
	public bool inventoryItem;
	public string collectMessage;

	[Header("Models")]
	public List<Mesh> meshes;


}
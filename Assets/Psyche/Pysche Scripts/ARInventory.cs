using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARInventory : MonoBehaviour {
    public Image[] img_SpacecraftParts = new Image[numItemSlots];
    public Item[] SpacecraftParts = new Item[numItemSlots];
    public const int numItemSlots = 26;
    public void AddItem (Item itemToAdd) {
        for (int i = 0; i < SpacecraftParts.Length; i++) {
            if (SpacecraftParts[i] == null) {
                SpacecraftParts[i] = itemToAdd;
                img_SpacecraftParts[i].sprite = itemToAdd.sprite;
                img_SpacecraftParts[i].enabled = true;
                return;
            }
        }
    }
    public void RemoveItem (Item itemToRemove) {
        for (int i = 0; i < SpacecraftParts.Length; i++) {
            if (SpacecraftParts[i] == itemToRemove) {
                SpacecraftParts[i] = null;
                img_SpacecraftParts[i].sprite = null;
                img_SpacecraftParts[i].enabled = false;
                return;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;
    private ItemSlot curSlot;
    public GameObject equipMark;

    public int index;
    public bool equipped;

    public void Set(ItemSlot slot)
    {
        curSlot = slot;
        icon.gameObject.SetActive(true);
        icon.sprite = slot.item.icon;

        if (equipMark.activeInHierarchy != false)
        {
            equipMark.SetActive(equipped);
        }
    }

    public void Clear()
    {
        curSlot = null;
        icon.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        PlayerInventory.Instance.SelectItem(index);
    }
}

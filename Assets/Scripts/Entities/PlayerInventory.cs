using UnityEngine;

public class ItemSlot
{
    public ItemData item;
    public int quantity;
}

public class PlayerInventory : MonoBehaviour
{
    public ItemSlotUI[] uiSlots;
    public ItemSlot[] slots;

    [Header("Selected Item")]
    private ItemSlot selectedItem;
    private int selectedItemIndex;

    public static PlayerInventory Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        slots = new ItemSlot[uiSlots.Length];

        // for (int i = 0; i < slots.Length; i++)
        // {
        //     slots[i] = new ItemSlot();
        //     uiSlots[i].index = i;
        //     uiSlots[i].Clear();
        // }

        // ClearSeletecItemWindow();
    }
}

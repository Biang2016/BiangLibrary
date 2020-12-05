using UnityEngine;

namespace BiangStudio.AdvancedInventory
{
    public abstract class InventoryItemInfoContainer : MonoBehaviour
    {
        public abstract IInventoryItemContentInfo ItemInfo { get; }
    }
}
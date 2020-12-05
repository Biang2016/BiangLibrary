using System.Collections.Generic;
using UnityEngine;

namespace BiangStudio.AdvancedInventory.UIInventory
{
    public class UIInventoryVirtualOccupationRoot : MonoBehaviour
    {
        internal List<UIInventoryVirtualOccupationQuad> uiInventoryVirtualOccupationQuads = new List<UIInventoryVirtualOccupationQuad>();

        internal void Clear()
        {
            foreach (UIInventoryVirtualOccupationQuad quad in uiInventoryVirtualOccupationQuads)
            {
                Destroy(quad.gameObject);
            }

            uiInventoryVirtualOccupationQuads.Clear();
        }
    }
}
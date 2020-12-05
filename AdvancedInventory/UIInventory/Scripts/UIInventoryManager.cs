using System.Collections.Generic;
using BiangStudio.Singleton;
using UnityEngine;

namespace BiangStudio.AdvancedInventory.UIInventory
{
    public class UIInventoryManager : TSingletonBaseManager<UIInventoryManager>
    {
        private Dictionary<string, UIInventory> UIInventoryDict = new Dictionary<string, UIInventory>();

        public void AddInventory(UIInventory uiInventory)
        {
            UIInventoryDict.Add(uiInventory.InventoryName, uiInventory);
        }

        public UIInventory GetInventory(string uiInventoryName)
        {
            UIInventoryDict.TryGetValue(uiInventoryName, out UIInventory uiInventory);
            return uiInventory;
        }

        public override void Update(float deltaTime)
        {
            foreach (KeyValuePair<string, UIInventory> kv in UIInventoryDict)
            {
                kv.Value.Update();
            }
        }

        public override void ShutDown()
        {
            base.ShutDown();
            UIInventoryDict.Clear();
        }
    }
}
﻿using BiangStudio.GameDataFormat.Grid;
using UnityEngine;
using UnityEngine.UI;

namespace BiangStudio.AdvancedInventory.UIInventory
{
    public class UIInventoryVirtualOccupationQuad : MonoBehaviour
    {
        /// <summary>
        /// If you use object pool, please invoke this function before reuse.
        /// </summary>
        public void OnRecycled()
        {
            Inventory = null;
        }

        void Awake()
        {
            RectTransform = (RectTransform) transform;
        }

        [SerializeField]
        private Image Image;

        [SerializeField]
        private Color AvailableColor;

        [SerializeField]
        private Color ForbiddenColor;

        private RectTransform RectTransform;
        private Inventory Inventory;

        public void Init(int gridSize, GridPos gp_matrix, Inventory inventory)
        {
            Inventory = inventory;
            GridPos gp_world = Inventory.CoordinateTransformationHandler_FromMatrixIndexToPos(gp_matrix);
            RectTransform.sizeDelta = gridSize * Vector2.one;
            RectTransform.anchoredPosition = new Vector2(gp_world.x * gridSize, gp_world.z * gridSize);
            Image.color = inventory.InventoryGridMatrix[gp_matrix.x, gp_matrix.z].Available ? AvailableColor : ForbiddenColor;
        }
    }
}
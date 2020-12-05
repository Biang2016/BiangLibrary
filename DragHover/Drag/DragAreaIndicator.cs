using UnityEngine;

namespace BiangStudio.DragHover
{
    [RequireComponent(typeof(BoxCollider))]
    public class DragAreaIndicator : MonoBehaviour
    {
        [HideInInspector]
        public BoxCollider BoxCollider;

        void Awake()
        {
            BoxCollider = GetComponent<BoxCollider>();
        }
    }
}
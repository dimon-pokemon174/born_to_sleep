using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Slot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public void OnDrop (PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().position =
            GetComponent<RectTransform>().position;
        }
    }
}

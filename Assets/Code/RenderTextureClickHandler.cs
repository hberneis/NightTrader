using UnityEngine;
using UnityEngine.EventSystems;

public class RenderTextureButtonInteraction : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        // Perform the desired action when the button is clicked
        Debug.Log("Button clicked!");
    }
}
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class XRObjectNameDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    private XRGrabInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
            interactable.hoverEntered.AddListener(OnHoverEntered);
            interactable.hoverExited.AddListener(OnHoverExited);
    }

    private void OnDisable()
    {
 
            interactable.hoverEntered.RemoveListener(OnHoverEntered);
            interactable.hoverExited.RemoveListener(OnHoverExited);
    }

    private void OnHoverEntered(HoverEnterEventArgs args)
    {
            textMeshPro.text = gameObject.name;
    }

    private void OnHoverExited(HoverExitEventArgs args)
    {
            textMeshPro.text = ""; // Clear the text when hover ends
    }
}

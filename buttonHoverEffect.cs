using UnityEngine;
using UnityEngine.EventSystems;

public class buttonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("ButtonHoverEffect started");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer entered");
        animator.SetBool("IsHovered", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer exited");
        animator.SetBool("IsHovered", false);
    }
}

//BUTTON HOVER COLOR HEX CODE---> FFC700
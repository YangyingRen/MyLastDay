using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragWindow : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    public RectTransform Window;
    // Start is called before the first frame update
   private void Awake(){
    Window=GetComponent<RectTransform>();
   }

    public void OnBeginDrag(PointerEventData eventData){

    }
    public void OnDrag(PointerEventData eventData){
        Window.anchoredPosition+=eventData.delta;
    }
    public void OnEndDrag(PointerEventData eventData){

    }


}

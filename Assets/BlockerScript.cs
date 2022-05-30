using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.EventSystems;

// public class BlockerScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
public class BlockerScript : MonoBehaviour
{
    
    // private RectTransform rectTransform;

    // private void Awake() {
    //     rectTransform = GetComponent<RectTransform>();
    // }

    // public void OnPointerDown(PointerEventData eventData) {
    //     Debug.Log("OnPointerDown");
    // }

    // public void OnBeginDrag(PointerEventData eventData){
    //     Debug.Log("OnBeginDrag");
        
    // }

    // public void OnEndDrag(PointerEventData eventData){
    //     Debug.Log("OnEndDrag");

    
    // }

    // public void OnDrag(PointerEventData eventData){
    //     Debug.Log("OnDrag");
    //     rectTransform.anchoredPosition += eventData.delta;
    // }

    private float startX;
    private float startY;
    private bool isBeingHeld;
    private bool isBeingRotated;

    void Update() {
        if(isBeingHeld == true){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startX, mousePos.y-startY, 0);
        }
        if(isBeingRotated == true){
            this.gameObject.transform.Rotate(0,0,-0.3f);
        }
    }

    private void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startX = mousePos.x - this.transform.localPosition.x;
            startY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
            Debug.Log("hello");
        }
        
    }

    private void OnMouseOver(){
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("hi");
            isBeingRotated = true;
        }
        if(Input.GetMouseButtonUp(1)){
            isBeingRotated = false;
        }

    }
    private void OnMouseOut(){
        isBeingRotated = false;
    }

    private void OnMouseUp(){
        isBeingHeld = false;
        isBeingRotated = false;
    }
}

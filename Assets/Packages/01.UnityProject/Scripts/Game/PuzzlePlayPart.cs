using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerMoveHandler
{
    private bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //마우스 버튼을 눌렀을때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData){
        isClicked = true;
        
        GFunc.Log($"{gameObject.name}을 선택했다");
    }
    // 마우스 버튼에서 손을 뗐을 대 동작하는 함수
    public void OnPointerUp(PointerEventData eventData){
        isClicked = false;
        
        GFunc.Log($"{gameObject.name}을 헤제했다.");
    }
    // 마우스를 드래그 중일 때 동작하는 함수
    public void OnPointerMove(PointerEventData eventData){
        if(isClicked){
            gameObject.SetLocalPos(eventData.position.x,eventData.position.y,0);
            GFunc.Log($"마우스의 포지션을 눈으로 확인:{eventData.position.x}{eventData.position.y}");
        }
    }
}

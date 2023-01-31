using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class PuzzlePlayPart : MonoBehaviour, IPointerDownHandler,IPointerUpHandler, IDragHandler
{
    public PuzzleType puzzleType = PuzzleType.NONE;
    private Image puzzleImg = default;
    private bool isClicked = false;
    private RectTransform ObjRect = default;
    private PuzzleInitZone puzzleInitZone = default;
    private PlayLevel playLevel = default;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        ObjRect = gameObject.GetRect();
        puzzleInitZone = transform.parent.gameObject.GetComponentMust<PuzzleInitZone>();
         puzzleImg = gameObject.FindChildObj("PuzzleLvParts_Img").GetComponentMust<Image>();

        playLevel = GameManager.Instance.gameObjs[GData.OBJECT_NAME_CURRENT_LEVEL].GetComponentMust<PlayLevel>();
        switch (puzzleImg.sprite.name)
        {
            case "Puzzle_BigTriangle":
                puzzleType = PuzzleType.PUZZLE_BIG_TRIANGLE;
                break;
            case "Puzzle_BigTriangle2":
                puzzleType = PuzzleType.PUZZLE_BIG_TRIANGLE;
                break;
            default:
                puzzleType = PuzzleType.NONE;
                break;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //마우스 버튼을 눌렀을때 동작하는 함수
    public void OnPointerDown(PointerEventData eventData){
        isClicked = true;

    }
    // 마우스 버튼에서 손을 뗐을 대 동작하는 함수
    public void OnPointerUp(PointerEventData eventData){
        GFunc.Log($"이 가장 가까이에있습니다.");
        isClicked = false;
        PuzzleLvPart closeLvPuzzle = 
        playLevel.GetCloseSameTypePuzzle(puzzleType, transform.position);

        
        if(closeLvPuzzle == null || closeLvPuzzle == default){
            return;
        }
        transform.position = closeLvPuzzle.transform.position;

    }
    // 마우스를 드래그 중일 때 동작하는 함수
    public void OnDrag(PointerEventData eventData){
        if(isClicked){
            gameObject.AddAnchoredPos(eventData.delta / puzzleInitZone.parentCanvas.scaleFactor);
        }
    }
}

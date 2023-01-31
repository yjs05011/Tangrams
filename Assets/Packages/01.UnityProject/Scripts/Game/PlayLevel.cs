using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLevel : MonoBehaviour
{
    public int level = default;
    public List<PuzzleLvPart> puzzleLvParts = default;

    private const float LV_PUZZLE_DISTANCE_LIMIT = 1f;

    public void Awake()
    {
        GameManager.Instance.gameObjs.Add(gameObject.name, gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        puzzleLvParts = new List<PuzzleLvPart>();

        for(int i=0; i<transform.childCount; i++)
        {
            puzzleLvParts.Add(transform.GetChild(i).
                gameObject.GetComponentMust<PuzzleLvPart>());

        }       // loop: ���� �������� ���� ������ ��� ĳ���ϴ� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<PuzzleLvPart> GetSameTypePuzzle(PuzzleType puzzleType){
        List<PuzzleLvPart> sameTypes = new List<PuzzleLvPart>();
        foreach(var PuzzleLvPart in puzzleLvParts){
            if(PuzzleLvPart.puzzleType.Equals(puzzleType)){
                sameTypes.Add(PuzzleLvPart);

            }else{
                continue;
            }
        }
        return sameTypes;
    }
    public PuzzleLvPart GetCloseSameTypePuzzle(PuzzleType puzzleType, Vector3 puzzleWorldPos){
        List<PuzzleLvPart> sameTypes = GetSameTypePuzzle(puzzleType);
        float minPosDistance = float.MaxValue;
        float distance = float.MaxValue;
        int index = 0;
        PuzzleLvPart result = default;
        foreach(var puzzleLvPart in sameTypes){
            
            distance = Mathf.Abs((puzzleLvPart.transform.position - puzzleWorldPos).magnitude);
            if( distance <= minPosDistance){
                minPosDistance = distance;
                result = puzzleLvPart;
            }
            index ++;
        }

        if(minPosDistance> LV_PUZZLE_DISTANCE_LIMIT){
            result = default;
        }
        return result;
    }
}

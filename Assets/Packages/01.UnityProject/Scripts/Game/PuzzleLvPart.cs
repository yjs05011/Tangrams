using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuzzleLvPart : MonoBehaviour
{
    private Image puzzleImg = default; 
    public PuzzleType puzzleType = PuzzleType.NONE;

    // Start is called before the first frame update
    void Start()
    {
        puzzleImg = gameObject.FindChildObj("PuzzleLvParts_Img").GetComponentMust<Image>();


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
}

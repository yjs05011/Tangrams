# Tangrams

Tangrams Practice unity project

issue.
- Summary 유니티 2D 프로젝트에서 오브젝트 드래그를 구현할 때 IpointerMoveHandler 사용해서 구현하는 중 이슈발생. (2023-01-30)
- Detail : 
	1. IPointerMoveHandler 에서 콜하는 OnPointerMove 메서드는 IDragHandler에서 구현하는 OnDrag메서드보다 
        호출속도가 느려서 오브젝트 드래그 도중에 오브젝트를 놓친다. (2023-01-30)
	2. PointerEventData에서 가지고 오는 마우스 position을 기준으로 오브젝트 위치를 계산할 때 오브젝트 자신의 
        피벗(Center)위치 만큼의 오차가 발생 했다. 오브젝트의 Local 포지션을 마우스 포인터를 기준으로 
	절대 좌표로 재설정 했을 때 피벗 이슈가 발생하는 것을 확인했다. (2023-01-30)
	3. 캔버스 하위에 위치한 오브젝트를 움직일 때 Local position을 연산해서 움직이며 Anchor의 Pivot과 
        Canvas의ScaleFactor 값 만큼의 오차가 발생하게 된다.     (2023-01-30)
        4. 싱글톤 구현 중 제네릭 T에 관련하여 NullReference가 나오는 현상 확인(2023-01-32)
- Solve :
    1. OnDrag 메서드를 사용해서 구현하는 것이 더 나은 방식인 것으로 추정된다. (2023-01-31)
    2. 오브젝트를 움직일 때 절대 좌표가 아닌 상대적인 움직임을 더해서 연산하는 방식이 오차가 적을 것으로 추정된다. (2023-01-31)
    3. Local position이 아닌, Anchored position과 ScaleFactor 값을 고려해서 연산하는 것이 오차가 적을 것으로 추정된다. (2023-01-31)
    4. 싱글톤 구현 중 제네릭 T 를 사용하기위해 새로운 오브젝트 생성 추가를 해야하는 것으로 추정 GFun에서 추가(2023-01-31)

2023-01-30 // 0.0.1 ver// start project

2023-01-30 // 0.1.0 ver // make main menu, add sprites

2023-01-31 // 0.1.1 ver // make playAct
2023-01-31 // 1.0.0 ver // make prototype(minmum func)
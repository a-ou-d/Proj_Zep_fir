# Proj_Zep_fir

## 구현 기능

* StartScene - 이름 입력 받기
  * 이름이 2자 이상, 10자 이하일 때만 버튼 활성화
* ChoiceScene - 캐릭터 선택
  * Character id를 0, 1, 2로 설정해 MainScene에서 id에 맞는 Character Prefab 출력
* MainScene - 캐릭터 움직임, 캐릭터 상단에 이름 출력
  * 키보드 W, A, S, D 로 움직이고, SPACE로 점프 가능
  * 캐릭터는 키보드 입력값이 없다면 마우스 포인터의 방향으로, 마우스 움직임이 없다면 키보드가 움직이는 방향을 바라봄
  * Layer, Sort Layer 조정으로 높낮이 표현 및 맵 내의 다른 물체들과 상호작용 가능

## 추가 예정

* 이름의 글자 수가 조건에 맞지 않을 경우 경고 메세지 출력
* NPC 이름 및 상호작용
* 시간 표시
* 참석 인원
* 배경 음악

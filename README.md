# SpartaDungeonUnity-Game

스파르타 던전 미니 게임 (Unity 버전)

<br>

## 💻 프로젝트 소개 💻

기존에 만들었던 스파르타 던전의 유니티 버전 게임입니다.

<br>

## 🕑 개발 기간 🕑

* 23.09.19 ~ 23.09

<br>

## ⚙️ 개발 환경 ⚙️

* `C# - v1.26.0`
* `.NET - 7.0`
* `Text Editor - Visual Studio Code`
* `Unity - Unity 2022.3.2f1`

<br>

## 🔫 구현 기능 🔫

#### 💡 필수 요구 사항 💡

* 메인 화면 구성
    - 아이디
    - 레벨
    - 골드
    - Status 버튼
        + 2. Status 보기
    - Inventory 버튼
        + 3. Inventory 보기

* Status 보기
    - Status 버튼, Inventory 버튼
        -> 사라지기
    - 우측에 캐릭터 정보 표현
    - 뒤로가기 버튼을 누르면 1번 화면으로 이동

* Inventory 보기
    - Status 버튼, Inventory 버튼 -> 사라지기
    - 우측에 인벤토리 표시
    - 아이템을 클릭하면 장착관리
        -> 아이템 장착 중 - X  : 장착 확인 팝업
        -> 아이템 장착 중 - O  : 장착해제 확인 팝업
    - 장착중인 아이템은 표시
    - 뒤로가기 버튼을 누르면 1번 화면으로 이동

#### 💡 선택 요구 사항 💡

* 아이템 장착 팝업 업그레이드
    - 아이템을 클릭하면 해당 정보가 팝업에 나타나도록 적용
* 상점 기능
    - 상점 버튼 추가
    - 구매 완료 후 팝업
    - 구매한 아이템은 인벤토리로 추가
    - 상점 아이템이 넘어간다면 스크롤 되게 적용

<br>
- ⭕️ 아이템 추가하기 - 인벤토리에 나만의 새로운 아이템을 추가해보기
- ❌ 레벨업 기능

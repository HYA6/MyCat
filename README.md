# :cat: MyCat

## 📌 개요
- **장르**: 퍼즐
- **게임 소개**: 단순 타임어택 미로찾기 게임, 각 스테이지별로 요구하는 구슬을 획득하면 다음 스테이지로 넘어갈 수 있는 게임
- **플랫폼**: Unity 2D (PC)
- **개발 기간**: 2024.08
- **개발 인원**: 1인
- **목적**: 게임 개발 입문
<br/>

## 🚀 주요 기능
- Tilemap 기반 미로 생성  
- 플레이어 이동
- URP 2D 라이트를 활용한 분위기 조명  
- UI: 남은 시간, 스테이지 클리어 여부 표시 
<br/>

## 🛠 기술 스택
- **언어**: C#  
- **엔진**: Unity 2022.3 LTS  
- **버전 관리**: Git, GitHub, Unity Cloud
- **구조**: 절차적·모듈화 중심
<br/>

## 🏗 구조 및 설계
### 주요 클래스
- `GameManager`: 버튼 로직 설정
- `GameClear`, `GameOver`: 게임 상태(진행/오버) 제어
- `Key`: 키 아이템 충돌 처리
- `Player`: 플레이어 조작 제어

### 폴더 구조
-  Assets/ <br/>
  ┣ 01.Scripts/ <br/>
  ┣ 02. Scenes/ <br/>
  ┣ 03. Sprites/ <br/>
  ┣ 04. Materials/ <br/>
  ┣ 05. Textures/ <br/>
  ┣ 06. Audio/ <br/>
  ┣ 07. Animations/ <br/>
  ┣ 08. UI/ <br/>
  ┗ 09. TextMesh Pro/ <br/>

<br/>

## ▶ 실행 방법
- 게임 다운로드 후 압출 풀면 게임 실행 파일(.exe)을 실행하면 됩니다.
- [[게임 다운로드]](https://drive.google.com/file/d/13IkvG3J6KnkiOf5Fvvi3BiEADWtLkdPi/view?usp=drive_link) - 구글 드라이브 연결
<br/>

## 🎥 시연 자료 및 상세 개발 과정
- [시연 영상 보기](https://youtu.be/33nC4d52ktU) - 유튜브 연결
- [개발 과정](https://hya68.tistory.com/8) - 블로그 연결
<br/>

## 🔮 개선 예정
- 스토리 추가
- 사운드 추가
- 아트 업그레이드
- 코드 최적화 및 리팩토링
<br/>

## 📚 학습 포인트
- Unity 2D 입문 (Tilemap, URP, Canvas, Collider 사용법 습득)
- 게임 기획, 개발, 빌드 로직 경험

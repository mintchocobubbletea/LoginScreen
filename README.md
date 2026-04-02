# (C# 코딩) 로그인 화면
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 아이디와 패스워드를 입력해야 하는 로그인 화면을 만들기
- 핵심기능: 엔터키로 로그인, 포커스 흐름 정리, 실패 횟수 제한, 사용자 확인 항목 추가 
- 화면구성: Label(프로그램 제목), Textbox, Button
- 사용한 플랫폼: 
	- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
	- Label, TextBox, Button
- 사용한 기술과 구현한 기능:
	- Visual Studio를 이용하여 UI 디자인
	- 로그인 가능 여부 체크 기능
	- 로그인 실패 횟수 제한 기능

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
<img width="1006" height="668" alt="Image" src="https://github.com/user-attachments/assets/8909ae69-9c08-4937-9030-281cc04986dc" />
<img width="796" height="510" alt="Image" src="https://github.com/user-attachments/assets/6a0de562-5754-4815-ab01-4bbbec7a4141" />
<img width="895" height="503" alt="Image" src="https://github.com/user-attachments/assets/43a97e9f-247c-45ad-9201-3021744b6d7d" />
<img width="1023" height="500" alt="Image" src="https://github.com/user-attachments/assets/c31b60c8-dfe5-40b5-a9f7-ea0524b7d18f" />

- 과제 내용
	- TextBox(아이디, 패스워드), Button(로그인) 등을 적절히 배치합니다.
	- Placeholder 표시 : 아이디와 패스워드 입력 힌트를 회색으로 표시합니다.
	- 아이디와 패스워드가 모두 맞아야 로그인 허용되게 합니다.
	- 메시지 박스로 로그인 성공/실패 메시지 보여줍니다
- 구현 내용과 기능 설명
	- UI 구성을 텍스트 박스와 버튼으로 구성합니다.
	- 텍스트 박스에 Placeholder 함수로 입력 힌트를 회색으로 표시합니다.
	- 로그인 가능 여부를 체크하는 기능 구현
- 사용한 기술과 구현한 기능:
	- button과 textbox 툴들을 이용하여 UI 디자인
	- 이벤트 메소드들을 툴들과 연결하여 기능 구현
	- 비밀번호 입력 텍스트 박스에 UseSystemPasswordChar 메소드 적용하여 글자 안 보이게 하거나 보이게 하는 기능 구현
	
## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷
<img width="528" height="528" alt="Image" src="https://github.com/user-attachments/assets/b157d856-ff64-4cbf-9f02-2eda01c5bf3e" />
<img width="837" height="549" alt="Image" src="https://github.com/user-attachments/assets/f5030473-9428-4a23-b299-b04e29cc014e" />

- 과제 내용
	- 아이디 또는 패스워드가 잘못 입력되었을 때 에러 메시지를 보여줍니다.
	- MessageBox를 띄우지 말고 아이디와 패스워드를 입력하는 곳에 보여줍니다.
	- 각 버튼 클릭 시 연산자만 변경하여 동일한 로직이 적용되도록 함
- 구현 내용과 기능 설명
	- Label 컨트롤을 추가하여 로그인 불가 안내 문구를 추가합니다.
	- Visible 속성을 이용해서 메시지 보이기와 숨기기 기능 구현합니다.
	- 로그인 불가 안내 문구 색을 변경하는 메소드 추가합니다.
	- && 연산자를 사용하여 아이디와 비밀번호 일치 여부를 확인한다.
- 사용한 기술과 구현한 기능:
	- button들을 추가하여 연산자 지정
	- 이벤트 메소드들을 툴들과 연결하여 기능 구현
	- 에러 메시지 레이블에 Visible 메소드를 사용하여 불일치시 보여주기 기능 구현
 
## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷
<img width="458" height="479" alt="과제 3" src="https://github.com/user-attachments/assets/68d3d6de-8932-4fc0-a93b-b36c169251c6" />
<img width="456" height="481" alt="과제3_1" src="https://github.com/user-attachments/assets/7a3c1c18-f039-42be-9b8e-5c81adb51b45" />


- 과제 내용
	- 아이디와 패스워드를 빠르게 입력하고 로그인 할 수 있도록 엔터키와 로그인 창을 연동함
	- Enter키를 치면 로그인 되도록 포커스 흐름 정리함
	- 편리한 UI/UX 구현하기 위해 기능을 추가함
- 구현 내용과 기능 설명
	- 아이디 입력박스에 키 다운 이벤트를 추가하여 Enter키 치면 패스워드 입력 창으로 넘어가기 기능 구현
	- 키 다운 메소드를 추가하여 패스워드 입력하고 Enter키 치면 로그인되는 기능 구현
	- 전체를 지우는 기능과 패스워드를 보여주는 기능 구현
- 사용한 기술과 구현한 기능:
	- 체크박스와 관련된 이벤트 메소드를 찾고 이를 통해 기능을 구현
	- 각 기능들에 필요한 버튼과 체크 박스를 만듦
	- 툴들에 알맞은 이벤트들을 작성하여 연결함

## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷
<img width="450" height="478" alt="과제4_3" src="https://github.com/user-attachments/assets/e586fc12-cd23-493a-ad51-d82ab8dad858" />
<img width="443" height="474" alt="과제4_2" src="https://github.com/user-attachments/assets/ec35de3e-889c-4584-aaed-b315dcab6bef" />
<img width="452" height="477" alt="과제4" src="https://github.com/user-attachments/assets/7c2da61e-ca90-4764-9c6c-9262f5b31369" />


- 과제 내용
	- 아이디와 패스워드 입력 문자 확인하게 하기
	- 로그인 시도 회수 제한을 두기 (2단계 확인 절차 추가)
	- 키보드로도 계산기 입력 가능하게 기능 구현

- 구현 내용과 기능 설명
	- 아이디에 넣을 수 없는 글자를 체크하기
	- 비밀번호에 넣을 수 없거나 꼭 들어가야 하는 문자 체크하기
	- 일정 회수가 지나면 정해진 시간 후에 재시도 가능하게 하기

- 사용한 기술과 구현한 기능:
	- id에 contains 메소드를 사용하여 만약 공백이 있으면 경고 문구가 뜨는 기능 구현
	- hasnumber 함수를 구현하여 비밀번호를 최소 8자 이상, 숫자 포함 필수인지 확인하는 기능 구현
 	- 필요한 변수를 추가하여 5회 이상 로근인에 실패할 시 30초 대기하는 기능 구현

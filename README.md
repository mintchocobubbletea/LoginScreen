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
	

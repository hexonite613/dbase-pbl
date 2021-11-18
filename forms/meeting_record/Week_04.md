# 팀 활동 보고서 - 4주차
## 미팅 정보
|참석자|
|-|
|박동준, 성주원, 손열혼, 박준엽|

|장소|시간|
|-|-|
|Zoom 온라인 세션|2021년 10월 7일|


## 미팅 내용
- ERD 다이어그램 & 스키마 구성 및 검토
- 테이블 정규화 (컬럼 분해, 중복 제거 등)
- 엔티티 간의 관계에 대해 논의

## 주요 사항
|![image](https://user-images.githubusercontent.com/24975076/139208608-aef299ad-316f-49fa-99d0-beffd78d75b2.png)|![image](https://user-images.githubusercontent.com/24975076/139208689-dd0e1109-a8b2-4a0b-94eb-21d19b7f4ac2.png)|
|-|-|
- 결제 릴레이션 재검토, 결제방식 채택 논의
  - 결제방식 -> 별도 릴레이션을 만들지 않고 pay_method 속성값을 두어 enum() 또는 char로 저장

## 교수님의 피드백

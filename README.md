# 필독!
- 코드가 구버전이라 주석이 깨져있습니다. EUC-KR로 리인코딩해주시면 주석내용이 보입니다!
- Because codes are legacy, all of comments are broken. Reencode to EUC-KR to see comments.

## 소개
"Break The Wall" Unity로 개발된 프로젝트입니다.
안드로이드 플랫폼에서 구동 가능하며, **러닝액션** 장르입니다.
현재는 작업을 하고있지 않은 프로젝트입니다.

## 주요 기능
- 캐릭터는 오른쪽 방향으로 계속 달리며, 다가오는 장애물을 피해 최대한 오래 달려야 하는 게임입니다.
- 플레이어가 수행할 수 있는 액션은 점프, 숙이기, 발차기이며, 발차기를 통해 벽을 부술 수 있습니다.
- 장애물은 상하방향으로 등장하며, 경우에 따라 벽이 등장합니다.
- 벽 이외에 발차기를 하면 안되는 덩굴이 등장하여 게임의 단조로움을 줄여줍니다.

## 구현 기능
- **무한 맵 메커니즘**. 뒷배경은 레이어로 분리시킨 뒤, 한쪽 방향으로 계속 이동시킴. 만약 설정한 구간에 도달하면 다시 처음으로 돌아가는 식으로 무한히 이동하게 설정
- **벽 생성 기술**. 일정 시간마다 일련의 패턴이 설정된 프리팹 배열에서 랜덤으로 숫자를 하나 뽑아 오브젝트 복제. 시간이 흐를수록 생성 주기 감소
- **랭킹 시스템**. 구글 플레이 스토어에서 제공하는 API 사용

## 기획적 특징
- 기존 러닝액션은 가로형으로 진행된다는 사실에서 착안하여, 세로형 비율로 게임 제작
- 러닝 액션 장르 특유의 점프 시스템에 '숙이기' 와 '발차기'를 추가하여 게임의 시스템적 다양성 추구
- 그럼에도 게임이 단조로워지는 현상이 보여, '덩굴'을 추가하여 발차기 패턴을 꼬아보는 식으로 새로운 시도를 해봄.

---

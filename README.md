# 撲克牌遊戲: 一本書

## 主要功能

本程式是名為一本書的紙牌對戰模擬遊戲，玩家將與三位人工智慧對手進行一場鬥智競賽，透過精準的詢問策略，集齊 4 張同數字卡牌以組成「一本書」並獲得分數，系統支援背景音樂自選與動態介面(包含中央資訊版紀錄遊戲資訊、玩家手牌會動態增減等功能)。

## 使用方法
#### 1. 開始介面
程式執行時進入初始介面介紹遊戲規則，點選開始遊戲後會自動播放一次「開始遊戲」的女聲音效

<img width="350" height="280" alt="開始" src="https://github.com/user-attachments/assets/18e24c45-c8b8-451d-a74b-d33587025a52" />
<br>

#### 2. 遊戲開始與流程規則
遊戲採取回合制，依序為：玩家 → 電腦A → 電腦B → 電腦C，當遊戲開始時由自己先行動

- 詢問機制： 輪到自己時，點擊下方的其中一張手牌，再點選「詢問」按鈕

- 卡牌交換： 若對手手中擁有您詢問的數字，對手必須交出該卡牌

- 自動抽牌： 若對手皆無此牌，系統會自動引導您從中央牌堆抽取一張卡牌，輪到下一位玩家回合

- 組成一本書： 每湊齊 4 張同數字的卡牌，系統會自動歸類為「一本書」並完成計分

<img width="350" height="280" alt="初始牌桌" src="https://github.com/user-attachments/assets/e54515b0-05d5-4292-8251-83252827f062" />
<br>

#### 3. 遊戲輔助機制
為了使遊戲過程中操作更直觀，設定了多種輔助機制

- 選牌提示： 未選牌前，系統會跳出提示詞「請點擊你要詢問的牌」，點擊手牌後，右下方會顯示「已選擇」的數字提示，防止誤觸詢問
<img width="350" height="230" alt="點擊你要詢問的牌" src="https://github.com/user-attachments/assets/bf58eed0-d6ae-4a26-af63-1ff22ed262b6" />
<img width="350" height="230" alt="已選擇" src="https://github.com/user-attachments/assets/ba432dc1-dfdc-4a63-aa69-59ce1669608d" />
<br>
<br>

- 遊戲規則提示： 為了防止玩家忘記遊戲規則，牌桌右上方有「遊戲規則」按鈕，點選後會跳出提示框顯示遊戲規則與流程
<img width="350" height="230" alt="遊戲規則" src="https://github.com/user-attachments/assets/9ec1940a-02d8-47b8-85e3-047c0654581a" />
<br>
<br>

- 遊戲日誌： 中央資訊欄會顯示剩餘的牌數與詳細的操作紀錄（包括誰詢問了什麼牌、誰給了誰幾張牌），方便回顧戰況
<img width="350" height="230" alt="image" src="https://github.com/user-attachments/assets/af8e42a1-f231-4737-9fb2-f23d3072dc59" />


<img width="344" height="313" alt="image" src="https://github.com/user-attachments/assets/10004901-fae1-4a28-985e-db82e5a0cc84" />


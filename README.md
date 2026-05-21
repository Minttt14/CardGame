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

- 手牌與書本數動態更新： 每位玩家剩餘的手牌數以及湊齊的書本數量都會動態更新，方便觀察當前戰況

<img width="350" height="100" alt="image" src="https://github.com/user-attachments/assets/ac64b953-1cd0-416b-bc92-e3b94614ae04" />
<br>
<br>

- 手牌過多處理： 當玩家的手牌超出可容納範圍時，自動改為卷軸，不影響選牌與查看功能
<img width="350" height="110" alt="image" src="https://github.com/user-attachments/assets/85827a36-ee47-4f6c-a1aa-c175999d2354" />
<br>
<br>

- 遊戲規則提示： 為了防止玩家忘記遊戲規則，牌桌右上方有「遊戲規則」按鈕，點選後會跳出提示框顯示遊戲規則與流程

<img width="350" height="230" alt="遊戲規則" src="https://github.com/user-attachments/assets/9ec1940a-02d8-47b8-85e3-047c0654581a" />
<br>
<br>

- 遊戲日誌： 中央資訊欄會顯示剩餘的牌數與詳細的操作紀錄（包括誰詢問了什麼牌、誰給了誰幾張牌），方便回顧戰況

<img width="350" height="230" alt="image" src="https://github.com/user-attachments/assets/af8e42a1-f231-4737-9fb2-f23d3072dc59" />
<br>

#### 4. 遊戲控制與個人化設定
- 音樂選單： 使用者若覺得遊戲過程太安靜，程式提供了音樂選單，包含三種音效可自選，按下「開始播放」按鈕後會不斷循環播放，按下「停止播放」按鈕則結束播放

<img width="350" height="200" alt="選擇音樂" src="https://github.com/user-attachments/assets/7998b40e-00f9-41a6-a705-ca94f7ea5105" />
<br>
<br>

- 重新開始： 可隨時在遊戲過程中使用，按下後會跳出提示框詢問是否重新開始，選擇「是」會重置整個牌桌

<img width="350" height="200" alt="遊戲中重新" src="https://github.com/user-attachments/assets/baa5ea83-e4b6-4a09-a9a8-1369df1731c1" />
<br>

#### 5. 遊戲結算頁面
遊戲結束後會顯示此局對局資訊，並設有「重新開始」與「結束遊戲」按鈕，點選「重新開始」按鈕會回到初始遊戲規則介面；點選「結束遊戲」按鈕則會關閉程式

<img width="350" height="280" alt="結算畫面" src="https://github.com/user-attachments/assets/2470e835-9e31-4b99-9d7c-8d281d96377e" />


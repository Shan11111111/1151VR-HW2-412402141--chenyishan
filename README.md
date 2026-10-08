# 1151VR-HW2-412402141-陳怡珊

專案使用之2D圖片為學生個人創作之作品
<img width="865" height="517" alt="image" src="https://github.com/user-attachments/assets/ac9edbff-e74a-4d55-a349-8700f69237bb" />

<br> 
1、github連結 : https://github.com/Shan11111111/1151VR-HW2-412402141--chenyishan
<br>
2、youtube連結 : https://youtu.be/MNqd4cCCYRs
<br>
3、說明製作流程和相關操作
<br>
A.製作流程
<br>
(1) 專案使用 Unity 建立一個 2D 平台跳躍遊戲，玩家需要控制角色由起點出發，沿著不同高度的平台移動與跳躍，最後抵達終點。
<br>
(2) 製作時先建立 Unity 2D 專案並匯入 2D 人物圖片，再建立角色物件、地板、平台與終點。角色加入 Rigidbody2D 與 Box Collider 2D，讓角色可以受到重力影響並與平台碰撞。
<br>(3) 角色控制部分使用 Vector2 與陣列實作。程式以 Vector2[] 陣列儲存左、右、上、下四個移動方向，玩家按下不同按鍵時，會從陣列取出對應的方向，並套用到角色的移動速度。水平移動時只修改 X 軸速度，同時保留原本的 Y 軸變量；跳躍與下跳時則保留 X 軸速度並修改 Y 軸速度。
<br>(4) 場景中另外建立多個平台，讓角色可以逐步向上跳躍。終點物件使用 Box Collider 2D 並勾選 Is Trigger，當角色碰到終點時，系統會顯示完成介面，並提供重新遊玩的按鈕。
<br>(5) 介面部分另外建立開始畫面，顯示操作說明與開始遊玩按鈕。按下開始後，遊戲才會正式進行。遊戲完成後則顯示「抵達終點」畫面，玩家可以選擇重新開始。
<br>(6) 音效部分加入背景音樂、跳躍音效、抵達終點音效以及按鈕音效，並使用不同的 Audio Source 分別控制，使遊戲操作回饋更加完整。
<br>
B.操作方式
<br>
•  A / ←：角色向左移動
•  D / →：角色向右移動
•  W / ↑ / Space：角色向上跳躍
•  S / ↓：角色向下移動／快速下降
•  點擊 Game Start：開始遊戲
•  抵達終點後點擊 Restart：重新開始遊戲
    角色向左移動時，人物圖片會自動水平翻轉；向右移動時則恢復原本方向。遊戲過程中需依序跳上不同平台，最後碰觸右上方的終點即可完成關卡。
<br>
4、Vector 與陣列的使用
    程式中使用 Vector2[] 陣列儲存角色的四個方向：
    <br>
private Vector2[] directions =
{
    new Vector2(-1f, 0f),   // 左
    new Vector2(1f, 0f),    // 右
    new Vector2(0f, 1f),    // 上
    new Vector2(0f, -1f)    // 下
};
<br>
    水平移動時保留角色原本的 Y 軸速度，因此角色在跳躍過程中仍可以左右移動，不會因水平移動而把 Y 軸速度歸零。
rb.linearVelocity = new Vector2(
    moveDirection.x * moveSpeed,
    rb.linearVelocity.y
);



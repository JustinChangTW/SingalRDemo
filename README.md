# SingalRDemo
## 聊天室範例
![](https://i.imgur.com/jRDBBf4.gif)


## 購物範例
![](https://i.imgur.com/c4GPZwr.gif)


## 同步輸入
![](https://i.imgur.com/wUj834F.gif)


## 同步畫面
1. 如何操作scroll
    1. Scroll取得垂直的值：`window.screenY`
    2. Scroll取得最高的值：`window.pageYOffset`
    3. 設定Scroll位置：`window.scrollTo(水平位置,垂值位置)`
    4. 監聽Scroll事件：`window.addEventListener('scroll',function(e){ dosomthing.....})`

2. 未解的Error
   當快速卷動時同步會失敗
   
4. 操作畫面
![](https://i.imgur.com/EEH1eqx.gif)


## 同步畫面巻軸使用Dom
1. 為了防止快速巻動時發生同步失敗，改使用Dom觸發
2. 操作畫面
![](https://i.imgur.com/fCigWT8.gif)


## 網頁版OTP驗證
![](https://i.imgur.com/vQKHreh.gif)


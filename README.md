SWII_Support
============

## 概要

拡張BNFから大まかなコードを生成するソフト．  

ソフトだけを使いたいかたは[ココ][BNFSupport]からダウンロード．．

[BNFSupport]:https://raw.githubusercontent.com/konta220/SWII_Support/master/BNFSupport.exe

###以下の問題を解決するために作成

* 今のトークンから次のトークンってどうだったっけ?
* 構文定義のミスを減らすため
* コーディング部分の一貫性

###2014年度版

意図的にコード生成部にバグ(First集合回り)を残した永遠にベータ版です．

本ソフトを改良して使って頂けると幸いです．  

「※この内容は個人の独断であり，所属する組織の公式内容ではありません」

## デモ

何はともあれ，見た方が早いのでスクリーンショットを示します．

拡張BNFを入力して，「BNFの確認」をクリック
![BNF記述画面](https://raw.githubusercontent.com/konta220/SWII_Support/master/Ohter/screen1.PNG)

確認したい拡張BNF文を選んで「正規表現で解説」をクリックすると，「[Regulex][]」で図解してもらえる．
![BNFの確認画面](https://raw.githubusercontent.com/konta220/SWII_Support/master/Ohter/screen2.PNG)

「大雑把にコード生成」では，以下の画面に同意していたける方のみ利用可.
![BNF記述画面](https://raw.githubusercontent.com/konta220/SWII_Support/master/Ohter/screen3.PNG)

ここから先の利用方法は試してみて．


## 拡張BNFとは?

私なりに説明してみた．分かりにくかったら，GoogleやWikipediaなりで検索して調べてみて．

例えば以下の一文があったとする．
`happiness ::= {VERY} HAPPY DOT`  
この一文の全て小文字で表されたhappinessは「非終端記号 "*happiness*" 」とする．

拡張BNFは正規表現に置換できるため，「[Regulex][]」を用いて図解すると以下の感じ.  
![happinessのBNF](https://raw.githubusercontent.com/konta220/SWII_Support/master/Ohter/eBNF_happy.png)

この文において大文字で表現`VERY`や`HAPPY`，`DOT`は「終端記号」と呼ばれ，VERYだけが0回以上繰り返すことができ，次のように表現ができる．


    例
     happy.
     very happy.
     very very happy.

さらに，日付を表現した「非終端記号 "*date*" 」を付け加える．

`date ::= (TODAY | YESTERDAY) IS`  
![happinessのBNF](https://raw.githubusercontent.com/konta220/SWII_Support/master/Ohter/eBNF_date.png)

これを先ほどの "*happiness*" を追加して "*note*" を表現すると，以下のようになる．

`note ::=  [date] happiness`  
![noteのBNF](https://raw.githubusercontent.com/konta220/SWII_Support/master/Ohter/eBNF_note.png)

上記の"*note*"は以下のように表現できます．

    例
     Today is happy.
     Today is verry happy.
     Yesterday is happy.

皆様の理解の手助けになれば幸いです．

## 参考サイト

正規表現で図解してくれる便利なサイト  
「Regulex」 http://jex.im/regulex/

[Regulex]:http://jex.im/regulex/  

拡張BNFについての説明  
「EBNF - Wikipedia」 http://ja.wikipedia.org/wiki/EBNF

[EBNF]:http://ja.wikipedia.org/wiki/EBNF




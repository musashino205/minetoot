# MineToot

## Summery
Minecraftのログを読み込んで、何かログが追加されたら日本語に変換したうえで Mastodon にTootできるプログラムです。

## Usage
[Twitter の投稿を IFTTT で Mastodon へ転送する。 - Qiita](http://qiita.com/yukimochi/items/f80a50a4486d0cb770dc)
の、ユーザーに対するアプリケーション認証まで行ってください。
## License
MIT License

Copyright (c) 2017 musashino205
Released under the MIT license
http://opensource.org/licenses/mit-license.php 

## 色々

### 注意事項
- Mastodon のアクセストークンは現状平文で保存されます
- ユーザー名フィルター、テキストフィルターは未実装です
- [スクリーンショット](https://mstdn.maud.io/@musashino205/2257289)

## 参考
### 正規表現・一部ロジック
[roamer7038/minecraft-log-slack](https://github.com/roamer7038/minecraft-log-slack)
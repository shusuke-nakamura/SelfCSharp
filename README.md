# SelfCSharp

## ソリューションの作成
### コマンド dotnet new sln

## プロジェクトの作成方法
### コマンド
### dotnet new console
### dotnet sln add xxxx.csproj

## プロジェクトの実行
### コマンド
### dotnet run
## dotnet run --project xxxx.csproj

## 備忘録
### 1 プロジェクトに複数の Main 関数がある場合
### プロジェクト設定ファイル.csproj の「StartupObject」に実行したい Main 関数が実装されたソースコードを完全修飾で指定する。
# GitHubActions.AzureAppservice
## Workflow
- PullRequestでTest実行
- Master pushでリリース
- リリース前にテスト実施できるようにneedsはコメントアウトしてある
コメントアウトを外す場合はTestJobも修正が必要

## 参考ドキュメント
### GitHubリファレンス
- [ワークフロー構文](https://docs.github.com/ja/actions/reference/workflow-syntax-for-github-actions)  
→基本的な流れ
- [GitHubコンテキスト](https://docs.github.com/ja/actions/reference/context-and-expression-syntax-for-github-actions)  
→if文やgithub.eventなどのコンテキスト
### Azure
- [Workflow サンプル](https://github.com/Azure/actions-workflow-samples/tree/master/AppService)
- [MSDN シークレット・認証の設定](https://docs.microsoft.com/ja-jp/azure/app-service/deploy-github-actions?tabs=applevel)  
 リポジトリ単位でSecret(GitHub Secret `repo/settings/secrets` )を保持できる。  
 Documentではデプロイ用の発行プロファイルや認証の保存方法が記載。  
 活用方法としてTest用の環境変数(コマンドライン引数)を設定することもできるはず(未実装)。  
 dotnet cliでの引数については[MSDN dotnet test](https://docs.microsoft.com/ja-jp/dotnet/core/tools/dotnet-test)を参照。

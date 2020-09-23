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
- [Workflow Sample](https://github.com/Azure/actions-workflow-samples/tree/master/AppService)
- [MSDN setup secrest](https://docs.microsoft.com/ja-jp/azure/app-service/deploy-github-actions?tabs=applevel)

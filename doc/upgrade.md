## 每次升级概要记录

### 3.1.0

#### AuthServer升级备注

- 数据库迁移需要额外执行脚本
```SQL
  update [AuthServer].[dbo].[IdentityServerClients]   set RequireClientSecret = 0,ConsentLifetime=NULL where clientId='AuthServer_App'
```
# 升级 ABP 框架

本文档解释当ABP框架发布一个新版本时,怎样升级你已存在的解决方案.

## ABP UPDATE 命令

ABP 框架 & 模块生态系统由数百个 NuGet 和 NPM 包组成. 手动更新所有这些软件包以升级您的应用程序会很麻烦。

[ABP CLI](CLI.md) 提供了一个方便的命令，可以使用单个命令更新解决方案中所有与 ABP 相关的 NuGet 和 NPM 包：
````bash
abp update
````
在终端里,解决方案的根文件夹中运行此命令。

> 如果您的解决方案有 Angular UI，您的解决方案中可能有 `aspnet-core` 和 `angular` 文件夹。在这两个文件夹的父文件夹中运行此命令。

### 数据库迁移

> 警告：迁移数据库时要小心，因为在某些情况下可能会丢失数据。在执行之前仔细检查生成的迁移代码。建议备份您当前的数据库。

当您升级到新版本时，如果您的数据库提供者是 **Entity Framework Core**，最好检查是否有数据库架构更改并升级您的数据库架构；


* 在包管理器控制台 (PMC) 中使用 `Add-Migration "Upgraded_To_Abp_4_1"` 或类似命令创建新迁移（在 Visual Studio 中将 `EntityFrameworkCore` 设置为 PMC 中的默认项目，并将 `.DbMigrator` 在解决方案资源管理器中设置为启动项目）。
* 运行 `.DbMigrator` 应用程序以升级数据库并播种初始数据。

如果 `Add-Migration` 生成一个空迁移，您可以在执行 `.DbMigrator` 之前使用 `Remove-Migration` 将其删除。

## 博客文章和指南

每当您升级您的解决方案时，强烈建议您查看 [ABP BLOG](https://blog.abp.io/) 以了解新版本的新功能和更改。我们会定期发布帖子并编写此类更改。

### 迁移指南

如果新版本为现有应用程序带来重大更改，我们会准备迁移指南。所有指南请参见 [迁移指南](Migration-Guides/Index.md) 页面。

### 升级 Startup 模板

有时我们会引入需要**在启动模板中进行更改**的新功能/更改。我们已经在新应用程序的启动模板中实现了更改。但是，在某些情况下，您需要手动对现有解决方案进行一些小的更改。

逐行记录必要的更改是不切实际的。在这种情况下，我们建议您创建一个示例解决方案，一个是现有版本，一个是新版本，并使用差异工具进行比较。您可以 [查看本指南](Migration-Guides/Upgrading-Startup-Template.md) 了解如何使用 WinMerge 应用程序进行操作。

## 语义版本控制和重大更改

我们正在努力保持语义版本控制规则，因此您不会对 3.1、3.2、3.3 等次要（功能）版本进行重大更改......

但是，在某些情况下，我们也可能会在功能版本中引入重大更改；

* ABP 有许多集成包，有时集成库/框架会发布主要版本并进行重大更改。在这种情况下，我们会仔细检查这些更改并决定是否升级集成包。如果变更的影响比较小，我们会更新集成包，并在发布博文中说明变更。在这种情况下，如果您使用过此集成包，则应按照博文中的说明进行操作。如果更改可能会破坏许多应用程序并且不容易修复，我们决定等到下一个主要的 ABP 框架版本发布时升级。
* 有时我们必须进行重大更改以修复主要错误或使用问题。在这种情况下，我们认为开发人员已经无法正确使用该功能，因此通过重大更改修复它没有问题。在这种情况下，该功能通常是很少使用的功能。同样，我们尝试将影响保持在最低限度。

## 预览版和每日构建

预览版和夜间构建可以帮助您在新的稳定版本之前尝试新功能并调整您的解决方案。

* [预览版](Previews.md) 通常在次要（功能）版本之前约 2 周发布（我们的次要版本开发周期约为 4 周）。
* [每日构建](Nightly-Builds.md) 每天晚上（周末除外）从开发分支发布。这意味着您可以尝试前一天的开发。

请参阅他们的文档以了解有关此类版本的详细信息。

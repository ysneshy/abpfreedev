// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.CmsKit.Admin.Contents;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Admin.Contents.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IContentAdminAppService), typeof(ContentAdminClientProxy))]
public partial class ContentAdminClientProxy : ClientProxyBase<IContentAdminAppService>, IContentAdminAppService
{
    public virtual async Task<ListResultDto<ContentWidgetDto>> GetWidgetsAsync()
    {
        return await RequestAsync<ListResultDto<ContentWidgetDto>>(nameof(GetWidgetsAsync));
    }
}

using Abp.Web.Mvc.Views;

namespace Groupon.Web.Views
{
    public abstract class GrouponWebViewPageBase : GrouponWebViewPageBase<dynamic>
    {

    }

    public abstract class GrouponWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected GrouponWebViewPageBase()
        {
            LocalizationSourceName = GrouponConsts.LocalizationSourceName;
        }
    }
}
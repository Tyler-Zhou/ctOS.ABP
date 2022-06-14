using ctOS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ctOS.Permissions;

public class ctOSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ctOSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ctOSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ctOSResource>(name);
    }
}

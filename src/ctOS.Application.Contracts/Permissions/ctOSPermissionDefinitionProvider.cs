using ctOS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ctOS.Permissions;

public class ctOSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var rootGroup = context.AddGroup(ctOSPermissions.GroupName, L("Permission:Library"));

        var libraryGroup = rootGroup.AddPermission(ctOSPermissions.Library.LibraryName, L("Permission:Library"));
        var booksPermission = libraryGroup.AddChild(ctOSPermissions.Library.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(ctOSPermissions.Library.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(ctOSPermissions.Library.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(ctOSPermissions.Library.Books.Delete, L("Permission:Books.Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ctOSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ctOSResource>(name);
    }
}

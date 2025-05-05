using Autolote_360.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Autolote_360.Permissions;

public class Autolote_360PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Autolote_360Permissions.GroupName);

        var booksPermission = myGroup.AddPermission(Autolote_360Permissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(Autolote_360Permissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(Autolote_360Permissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(Autolote_360Permissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Autolote_360Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Autolote_360Resource>(name);
    }
}

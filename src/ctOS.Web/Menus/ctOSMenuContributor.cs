using System.Threading.Tasks;
using ctOS.Localization;
using ctOS.MultiTenancy;
using ctOS.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace ctOS.Web.Menus;

public class ctOSMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();

        var l = context.GetLocalizer<ctOSResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ctOSMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        var bookStoreMenu = new ApplicationMenuItem(
            "Library",
            l["Menu:Library"],
            icon: "fa fa-book"
        );

        context.Menu.AddItem(bookStoreMenu);

        //CHECK the PERMISSION
        if (await context.IsGrantedAsync(ctOSPermissions.Library.Books.Default))
        {
            bookStoreMenu.AddItem(new ApplicationMenuItem(
                "Library.Books",
                l["Menu:Books"],
                url: "/Library/Books"
            ));
        }


        //context.Menu.AddItem(
        //    new ApplicationMenuItem(
        //        "Library",
        //        l["Menu:Library"],
        //        icon: "fa fa-book"
        //    ).AddItem(
        //        new ApplicationMenuItem(
        //            "Library.Books",
        //            l["Menu:Books"],
        //            url: "/Library/Books"
        //        )
        //    )
        //);

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}

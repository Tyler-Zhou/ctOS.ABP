using Volo.Abp.Settings;

namespace ctOS.Settings;

public class ctOSSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ctOSSettings.MySetting1));
    }
}

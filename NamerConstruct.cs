using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.TfModuleStack;

namespace MyCompany.MyApp;

public class NamerConstruct : TFModuleStack
{
    public NamerConstruct(Construct scope, string id) : base(scope, id)
    {
        var resourceName = new TFModuleVariable(this, "resourceName", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The name of the resource",
            });

        var location = new TFModuleVariable(this, "location", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The location/region for the resource",
            });
    }
}
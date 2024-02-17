using System.Globalization;
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
        
        var service = new TFModuleVariable(this, "service", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The name of the service",
            });

        var resourcetype = new TFModuleVariable(this, "resourcetype", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The type of the resource",
            });

        var location = new TFModuleVariable(this, "location", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The location/region for the resource",
            });

            var localSerivce = "Azure";
            var localResourceType = "ResourceGroup";

            if(service.StringValue == "Azure")
            {
                localSerivce = nameof(Names.Azure);
            }

            if(resourcetype.StringValue == "ResourceGroup")
            {
                localResourceType = nameof(Names.Azure.ResourceGroup);
            }
            else if(resourcetype.StringValue == "StorageAccount")
            {
                localResourceType = nameof(Names.Azure.StorageAccount);
            }

             var namer = new Namer(resourceName.StringValue, location.StringValue);

        new TFModuleOutput(this, "name", new TerraformOutputConfig
            {
                Value = namer.Name[localSerivce][localResourceType]
            });
    }
}
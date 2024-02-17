using System;
using Constructs;
using HashiCorp.Cdktf;


namespace MyCompany.MyApp
{
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id) : base(scope, id)
        {
            TerraformVariable resrouceName = new TerraformVariable(this, "resourceName", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The name of the resource",
            });

            TerraformVariable location = new TerraformVariable(this, "location", new TerraformVariableConfig
            {
                Type = "string",
                Description = "The location/region for the resource",
            });

             var resourceGroupName = new Namer(resrouceName.StringValue, location.StringValue);

            new TerraformOutput(this, "name", new TerraformOutputConfig
            {
                Value = resourceGroupName.Name[nameof(Names.Azure)][nameof(Names.Azure.ResourceGroup)]
            });
        }
    }
}
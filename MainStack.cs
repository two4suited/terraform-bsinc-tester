using System;
using Constructs;
using HashiCorp.Cdktf;


namespace MyCompany.MyApp
{
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id) : base(scope, id)
        {
             var resourceGroupName = new Namer("myapp", "uswest");

            new TerraformOutput(this, "name", new TerraformOutputConfig
            {
                Value = resourceGroupName.Name[nameof(Names.Azure)][nameof(Names.Azure.ResourceGroup)]
            });
        }
    }
}
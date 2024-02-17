// using System;
// using Constructs;
// using HashiCorp.Cdktf;
// using HashiCorp.Cdktf.TfModuleStack;


// namespace MyCompany.MyApp
// {
//     class MainStack : TFModuleStack
//     {
//         public MainStack(Construct scope, string id) : base(scope, id)
//         {
//             var resrouceName = new TerraformVariable(this, "resourceName", new TerraformVariableConfig
//             {
//                 Type = "string",
//                 Description = "The name of the resource",
//             });

//             TerraformVariable location = new TerraformVariable(this, "location", new TerraformVariableConfig
//             {
//                 Type = "string",
//                 Description = "The location/region for the resource",
//             });

//              var resourceGroupName = new Namer(resrouceName.StringValue, location.StringValue);

//             new TerraformOutput(this, "name", new TerraformOutputConfig
//             {
//                 Value = resourceGroupName.Name[nameof(Names.Azure)][nameof(Names.Azure.ResourceGroup)]
//             });
//         }
//     }
// }
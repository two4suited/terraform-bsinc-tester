using System.Collections.Generic;

public static class Names
{

    public static Azure Azure => new Azure();
}

public class Azure
{
    public string ResourceGroup;
    public string StorageAccount;
   
}
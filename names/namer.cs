using System.Collections.Generic;

public class Namer
{
    private readonly string _applicationName;
    private readonly string _location;

    public Namer(string applicationName, string location)
    {
        _applicationName = applicationName;
        _location = location;
    }
    public Dictionary<string,Dictionary<string,string>> Name => new Dictionary<string,Dictionary<string,string>>
    {
        {"Azure", 
            new Dictionary<string,string> {
                {"ResourceGroup", $"{_applicationName}-RG123213-{_location}"}, 
                {"StorageAccountName", $"{_applicationName}sa{_location}"}
            }
        }
    };
           
}



[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)  // multiuse attribute
]
public class Author : System.Attribute
{
    private string name;
    public double version;

    public Author(string name)
    {
        this.name = name;
        version = 1.0;
    }
}

[Author("K. Marks", version = 1.1)]
[Author("F. Engels", version = 1.2)]
class Capital
{
    // K. Marks's code goes here...
    // F. Engels's code goes here...
}

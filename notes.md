# Notes

## Ch. 2 Naming and Handling Classes 

* Think about setting up a naming scheme for you different Project names. 
    * Example:
        * `CompanyName.Web`
        * `CompanyName.Win`
        * `CompanyName.Data`
        * `CompanyName.Wpf`
        * `CompanyName.BusinessLogic`
        * `CompanyName.Common`
        * etc.

**Unit Tests**

* It's good to have a dedicated Project in the Solution for your unit tests
* Right-click -> Add -> New Project...
* Built-in template: _MSTest Test Project_
* Add a Reference to the Project you're testing

**3 Steps of Test-Driven Development**

1. Arrange 
2. Act
3. Assert

Visual Studio Test Explorer

* Ctrl+E, T
* Test > Test Explorer

> _Make your methods private by default. Only make them public if you have to._

How to write XML documentation comments:

```C#
/// <summary>
/// Write some description...
/// </summary>
/// <returns>
/// Write some description...
/// </returns>
public string SomeMethod ()
{...}
```

---
End of document
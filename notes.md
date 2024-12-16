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
* You can Right-click > Debug a specific test from the Test Explorer

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

**Naming Conventions**

* Fields should be camelCase
* Properties should be PascalCase
* Methods should be PascalCase
* Method parameters should be camelCase 
* Class names should be PascalCase 
* Don't use prefixes in variable names 
* Namespaces should be PascalCase

**Structure**

* Use backing fields for properties 
* One class per file 
* Keep classes small 

You can chain constructors together in a class and have constructors call each other (similar to how you can have a derived class call its base class constructor):

```C#
public MyClass () 
{...}

public MyClass (string myParam) : this() 
{...}
```

Tip: in Visual Studio, Right-click -> "Remove and sort usings" will clean up the unused using statements at the top of the file for you. 

**Namespaces**

* Use a consistent, pre-defined naming convention
    * Ex: <Company>.<Technology>.<Feature>
* Don't use "System" 
* Don't use the same name as your class names 

A _Reference_ in Visual Studio allows one project to find another project. 

**Static Classes**

* Use them sparingly 
* Best for support/helper classes. Ex: common utilies
* Don't use them as a junk drawer 

---
End of document
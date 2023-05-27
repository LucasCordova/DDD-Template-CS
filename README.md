# DDD Template with Identity

## Steps Used to Create This Template

### Get the Base Template

If you have not previously installed the Clean Architecture Template, install it now:

```dotnetcli
dotnet new -i Ardalis.CleanArchitecture.Template
```

Navigate to the directory where you will put the new solution.

Run this command to create the solution structure with the name `App`:

```dotnetcli
dotnet new clean-arch -o App
```

### Add the Identity and Code Generation .NET Tools

If you have not previously installed the ASP>NET Code scaffolder, install it now

```dotnetcli
dotnet tool install -g dotnet-aspnet-codegenerator
```

Add a package reference to Microsoft.VisualStudio.Web.CodeGeneration.Design to the Web project (.csproj) file. Run the following command in the App.Webproject directory:

```dotnetcli
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet restore
```


```dotnetcli
dotnet aspnet-codegenerator identity -u WebApp1User -fi Account.Register;Account.Manage.Index
```

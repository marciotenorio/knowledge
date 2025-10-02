# .NET Reference

# Summary

- [. . /Frameworks](../frameworks.md)
- [Return Types](./Controllers/ReturnTypesController.cs)


# Configuration Files  
[Environments](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-9.0)  
[Configuration](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-9.0&source=recommendations)  

The **appsettings.json** and **launchSettings.json** files are important configuration files in ASP.NET Core, but they serve different purposes.

In summary:  
- **launchSettings.json** → controls application startup (local only).  
- **appsettings.json** → controls runtime parameters (used in all environments).  

## launchSettings.json
Used only in local development, it defines how the application will start.  
- Not published with the application.  
- Values defined here override system environment variables.  
- Can contain multiple *profiles* (dev, staging, etc.), each with its own environment variables.  

Example of a profile setting the `ASPNETCORE_ENVIRONMENT`:  

```json
"profiles": {
  "hlg": {
    "commandName": "Project",
    "applicationUrl": "https://localhost:8080;http://localhost:8081",
    "environmentVariables": {
      "ASPNETCORE_ENVIRONMENT": "HLG"
    }
  }
}
```

## appsettings.json
Used to configure the application at runtime.  
- Contains settings like URLs, connection strings, logging, and other parameters.  
- Can have environment-specific versions (e.g., `appsettings.Development.json`, `appsettings.Staging.json`).  
- The file loaded depends on the `ASPNETCORE_ENVIRONMENT` variable, defined in `launchSettings.json` or via CLI/OS.  

---
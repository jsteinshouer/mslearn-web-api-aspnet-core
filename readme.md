
https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/3-exercise-create-web-api

```
mkdir ContosoPizza
cd ContosoPizza
dotnet new webapi -controllers -f net8.0
```

Installed the Rest Client extension and ran .http file

Install the httprepl

```
dotnet tool install -g Microsoft.dotnet-httprepl
export PATH="$PATH:/root/.dotnet/tools"
httprepl http://127.0.0.1:5093/
```

Istall .net 7

```
wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

apt-get update && \
  apt-get install -y dotnet-sdk-7.0
```


https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/4-aspnet-controllers


Implement Model, Service, and Controller

https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/7-crud


https://learn.microsoft.com/api/achievements/share/en-us/JasonSteinshouer-8211/FZN7TFQX?sharingId=BF01F0F8575D8EDB

https://learn.microsoft.com/en-us/training/modules/publish-azure-web-app-with-visual-studio

```
dotnet publish -c release
```

right clicke on subscription and choose open in portal

Go to Resouces in left menu
Click Create
Click Create under Web App
Chose .NET 8 as stack
Chose Linux OS
Chose Free price plan
Click Review and Create then create
//Go to Configuration and set startup command to `dotnet ContosoPizza.dll`

  "Kestrel": {
    "EndPoints": {
      "Http": {
        "Address": "0.0.0.0",
        "Port": 8181
      }
    }
  },

    
  <location path="." inheritInChildApplications="false">
    <system.webServer>
      <handlers>
        <remove name="aspNetCore"/>
        <add name="aspNetCore" path="*" verb="*" modules="AspNetCoreModuleV2" resourceType="Unspecified"/>
      </handlers>
      <aspNetCore processPath="dotnet" arguments=".\ContosoPizza.dll" hostingModel="inprocess" stdoutLogEnabled="false" stdoutLogFile=".\logs\stdout" />
    </system.webServer>
  </location>


  [List of Project folders and descriptions for a web app](https://learn.microsoft.com/en-us/training/modules/publish-azure-web-app-with-visual-studio/6-explore-your-visual-studio-app-project)

  https://www.hanselman.com/blog/right-click-publish-quickly-to-azure-app-services-with-vs-code-extensions-and-zipdeploy

  https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/tutorials/publish-to-azure-webapp-using-vscode.md
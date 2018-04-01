# Velib Gateway Web Service

[https://gitlab.miaounyan.eu/piernov/si4-ws-velib]

## Extensions

 * Development: Graphical User Interface for the client
 * Deployment

## Content

### JCDecauxAPILibrary

This is the client library for the JCDecaux REST API. Basically sends some GET request and parse the JSON output.

### VelibSoapServiceLibrary

This is the actual gateway web service. Makes use of `JCDecauxAPILibrary` and implements a SOAP web service.

### VelibSoapWebApplication

This is the docker host for the `VelibSoapServiceLibrary` service.


#### Build & run

Built upon an ASP.NET Core project, it can be deployed into Linux Docker containers using the provided `docker-compose.yml` on both Linux and Windows.

```
docker-compose up velibsoapwebapplication
```

### VelibSoapClientConsole

A console client for the `VelibSoapWebApplication` web service. Provides a CLI prompt with the following commands:

```
Available commands:
    help                                        — display this message
    quit                                        — close the application
    connect [url]                               — connect to the webservice with an optional url
    list contracts                              — list contract names
    list stations <contract name>               — list station names for a given contract
    get contract <contract name>                — get details about a contract
    get station <contract name> <station name>  — get details about a station of a contract
Note: name containing whitespaces should be enclosed with "".
```

You must first connect to a web service using the connect command with a valid URL.

You can use `http://servers.piernov.org:5050/VelibSoapService.svc` as a remote web service, or `http://localhost:5050/VelibSoapService.svc` after a local Docker deployment of `VelibSoapWebApplication`.

#### Build & run

Build upon a .NET Core console application, it can be deployed into Linux Docker container using the provided `docker-compose.yml` on both Linux and Windows.

It is also dockerized and can be run using the provided `docker-compose.yml`:

```
docker-compose run velibsoapclientconsole
```

You may also run it using Visual Studio.

### VelibSoapClientWinForms

A GUI client for the `VelibSoapWebApplication` web service. Lists the contracts and the associated stations with details on the selected station.

#### Build & run

This is a WinForms application, it is only compatible with the full .NET Framework on Windows

Build and run using Visual Studio.

You must first connect to a web service using the Connect button after typing in the URL.

You can use `http://servers.piernov.org:5050/VelibSoapService.svc` as a remote web service, or `http://localhost:5050/VelibSoapService.svc` after a local Docker deployment of `VelibSoapWebApplication`.

### VelibSoapService

This is a WCF Application hosting `VelibSoapServiceLibrary` inside IIS. 

The actual WSDL may differ from `VelibSoapWebApplication`, thus the client apps may need some adjustements to be compatible with this service.

Use `VelibSoapWebApplication` instead.

#### Build & run

This is a WCF Service, it is only compatible with the full .NET Framework on Windows.

Build and run using Visual Studio.

The service will be available at `http://localhost:51460/VelibSoapService.svc`.

# Velib Gateway Web Service

[https://gitlab.miaounyan.eu/piernov/si4-ws-velib]

## Extensions

 * Development: Graphical User Interface for the client
 * Deployment
 * Event-based

Note: Deployment and Docker and Event-based service are not compatible

## Content

### JCDecauxAPILibrary

This is the client library for the JCDecaux REST API. Basically sends some GET request and parse the JSON output.

### VelibSoapServiceLibrary

This is the actual gateway web service. Makes use of `JCDecauxAPILibrary` and implements a SOAP web service.

### VelibSoapWebApplication

This is the docker host for the `VelibSoapServiceLibrary` service. Doesn't work with the event-based service, .NET Framework is needed.

### VelibSoapClientConsole

A .NET Framework Console client for the `VelibSoapWebApplication` web service. Provides a CLI prompt with the following commands:

```
Available commands:
    help                                                       - display this message
    quit                                                       - close the application
    connect                                                    - connect to the webservice
    list contracts                                             - list contract names
    list stations <contract name>                              - list station names for a given contract
    get contract <contract name>                               - get details about a contract
    get station <contract name> <station name>                 - get details about a station of a contract
    subscribe station <contract name> <station name> <period>  - subscribe to available bike changes
Note: name containing whitespaces should be enclosed with "".
```

You must first connect to a web service using the connect command with a valid URL.

You can use `http://localhost:5050/VelibSoapService.svc` after starting VelibSoapServiceHost.

#### Build & run

You may run it using Visual Studio.

### VelibSoapClientWinForms

A GUI client for the `VelibSoapWebApplication` web service. Lists the contracts and the associated stations with details on the selected station.

#### Build & run

This is a WinForms application, it is only compatible with the full .NET Framework on Windows. Doesn't work with the event-based service.

### VelibSoapService

This is a WCF Application hosting `VelibSoapServiceLibrary` inside IIS. Doesn't work with the event-based service.

Use `VelibSoapServiceHost` instead.

### VelibSoapServiceHost

This is a .NET Framework Console application hosting `VelibSoapServiceLibrary`. Works with the event-based service.

#### Build & run

You may run it using Visual Studio.
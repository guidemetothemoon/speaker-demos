# Introduction

This repo contains resources used for demos in my tech session **"Standardizing microservice-to-AKS workflow with dotnet custom templates and Azure DevOps"**.

# Useful resources

- Official Microsoft documentation for custom dotnet templates: [Custom templates for dotnet new](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates)

- 3-step Tutorial from Microsoft that shows different ways of creating and packaging custom dotnet templates: [Tutorial: Create templates for the CLI](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)

- .NET template Engine Wiki: [dotnet/templating](https://github.com/dotnet/templating/wiki)

- Kris - The Coding Unicorn blog post on easily creating microservices with dotnet custom templates: [How to Create New Microservices Easily With Dotnet Custom Templates](https://kristhecodingunicorn.com/post/dotnet_custom_templates/)

- Interesting dotnet custom template samples that also include examples on how to create templates that can be loaded from Visual Studio: [template-sample: Info on how to create templates that work in dotnet new and Visual Studio/Visual Studio for Mac](https://github.com/sayedihashimi/template-sample)

# Demo resources

Collection of custom dotnet templates that were used during the demo can be found in ```dotnet-templates``` folder. If you want to test them out for yourself, you can:

- Install them locally from file path:

```dotnet new install ./dotnet-templates/templates/microservice-aspnetweb```

```dotnet new install ./dotnet-templates/templates/microservice-security```

  Or, package them as a NuGet package with ```dotnet pack```, publish to a NuGet feed of your choice with ```dotnet nuget push <FULL_PATH_TO_NUPKG_FILE> -s <NUGET_FEED_SOURCE>``` and install the templates from the NuGet feed with ```dotnet new install <NUGET_PACKAGE_NAME>```

- Create a test-app folder based on msvc-aspnet template in the current directory by running ```dotnet new msvc-aspnet -n test-app  -s TestApp``` . Or, in the directory of your choice by running ```dotnet new msvc-aspnet -n test-app  -s TestApp -o <OUTPUT_DIRECTORY>```.

- Create security tasks for Azure Pipelines based on mscvc-sec template in the same test-app folder by running ```dotnet new msvc-sec -n test-app -o ./test-app```. 

Or, if you installed previous template in the directory of your choice, you can update the command like this: ```dotnet new msvc-sec -n test-app -o ./<OUTPUT_DIRECTORY>/test-app```

And you're ready to build and run the test app! :)

In order to test it from Azure DevOps, it will require some more adjustments from you:

- Create a build pipeline in Azure Pipelines and point it to test-app ```azure-pipeline.yml``` file
- Create an AKS cluster with HTTP Application Routing add-on enabled
- Create and Azure DevOps Environment and a Kubernetes resource with test-app namespace
- Create a variable group in ADO Libraries called ```ado-environments``` with ```ADOEnvDev``` variable that has value equal to your ADO Environment name;
- Update ```[AKS_DNS_ZONE]``` in ```helm``` folder, in ```values.yaml``` with DNS Zone name that was generated for your AKS cluster;

![image](https://user-images.githubusercontent.com/47773700/216837011-accdf44e-6b8a-4b99-9ef9-50eee799deee.png)

# Introduction

This repo contains resources used for demos in my tech session **"Deploying microservices to AKS with Azure DevOps Environments and multi-staged Azure Pipelines"**.

In this repo you can find:

```src``` 

This folder contains source code for CatEncyclopedia application which is a lightweight .NET 7 web app that is filled with cat love [^1] :-)
![image](https://user-images.githubusercontent.com/47773700/211924964-8429709f-9deb-4802-a851-b1fbcc39358a.png)


```docker``` 

This folder contains ```Dockerfile``` that is used to containerize CatEncyclopedia application. The application builds two types of container images: a regular .NET 7 Ubuntu image and a hardened image that uses Ubuntu Chiseled Containers (see Dockerfile in ```chiseled``` folder). You can use these files to build container images locally, but you can also download latest stable images from Docker Hub: [guidemetothemoon/cat-encyclopedia](https://hub.docker.com/r/guidemetothemoon/cat-encyclopedia). 

You can pull the images directly with these commands:

- Regular image: ```docker pull guidemetothemoon/cat-encyclopedia:1.6.59```

- Hardened image: ```docker pull guidemetothemoon/cat-encyclopedia:1.6.59-chiseled```

```helm```

This folder contains Helm chart for containerized CatEncyclopedia application. If you want to create a Helm chart for the regular CatEncyclopedia image you should use ```values.yaml``` configuration file. If you want to create a Helm chart for the hardened CatEncyclopedia image you should use ```values-chiseled.yaml``` configuration file.

You can package the Helm chart locally with this command: 
```helm package --destination . --version <package_version_of_your_choice> --app-version <app_version_of_your_choice> ./helm/cat-encyclopedia```

Once the Helm chart if packaged to a ```.tgz``` file you can deploy it to a Kubernetes cluster with these commands:

- Helm chart based on regular image: 

```helm upgrade --namespace cat-encyclopedia --install --wait --create-namespace --timeout 5m -f ./helm/cat-encyclopedia/values.yaml --set image.tag=<app_version_of_your_choice> cat-encyclopedia ./cat-encyclopedia-<app_version_of_your_choice>.tgz```

- Helm chart based on hardened image:

```helm upgrade --namespace cat-encyclopedia --install --wait --create-namespace --timeout 5m -f ./helm/cat-encyclopedia/values-chiseled.yaml --set image.tag=<app_version_of_your_choice>-chiseled cat-encyclopedia ./cat-encyclopedia-<app_version_of_your_choice>.tgz```

```azure-pipeline.yaml```

This file contains Azure Pipelines build pipeline that builds CatEncyclopedia application, builds and publishes regular and hardened container image, packages Helm chart and deploys two instances of application based on the Helm chart with regular and hardened configuration files to an AKS cluster, with Azure DevOps Environments.

# Useful resources

1. Azure DevOps SaaS registration for a free account: [Azure DevOps](https://azure.microsoft.com/en-us/products/devops/)
2. Azure DevOps labs to get started with Azure DevOps services: [Azure DevOps Labs](https://azuredevopslabs.com/)

3. Blog post series on Continuous Delivery to AKS with Azure DevOps Environments:
    * Part 1: [Continuous Delivery to AKS With Azure DevOps Environments - Part 2](https://kristhecodingunicorn.com/post/k8s_ado_envs-1)
    * Part 2: [Continuous Delivery to AKS With Azure DevOps Environments - Part 1](https://kristhecodingunicorn.com/post/k8s_ado_envs-2)

4. Tech tip on re-using Azure DevOps Environment efficiently across pipelines: [Re-Using Azure DevOps Environment Efficiently Across Multiple Pipelines](https://kristhecodingunicorn.com/techtips/ado_env_as_var/)'

5. Tech tip on resolving Azure DevOps Environment error related to ServiceAccount when targeting Kubernetes clusters version 1.24 and newer: [How to Fix ServiceAccount Error in Azure DevOps Environments for Kubernetes Clusters V.1.24 and Newer](https://kristhecodingunicorn.com/techtips/ado_sa_error/)

6. Script for migration of Kubernetes resources to a new Azure DevOps Environment: https://github.com/guidemetothemoon/div-dev-resources/tree/main/scripts/kubernetes/ado-environments

7. Microsoft Docs - Azure DevOps Environments: [Deploy apps to environments](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/environments?view=azure-devops)

8. AKS HTTP Application Routing add-on: [HTTP application routing](https://docs.microsoft.com/en-us/azure/aks/http-application-routing)

[^1]: Cat picture taken from Google Picture Search.
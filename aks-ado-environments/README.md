# Introduction

This repo contains resources used for demos in my tech session **"Deploying microservices to AKS with Azure DevOps Environments and multi-staged Azure Pipelines"**.

In this repo you can find:

```src``` 

This folder contains source code for CatEncyclopedia application which is a lightweight .NET 7 web app that is filled with cat love :-)

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

```azure-pipeline.yaml``

This file contains Azure Pipelines build pipeline that builds CatEncyclopedia application, builds and publishes regular and hardened container image, packages Helm chart and deploys two instances of application based on the Helm chart with regular and hardened configuration files to an AKS cluster, with Azure DevOps Environments.

# Useful resources

1. Blog post series on Continuous Delivery to AKS with Azure DevOps Environments:
    * Part 1: [Continuous Delivery to AKS With Azure DevOps Environments - Part 2](https://kristhecodingunicorn.com/post/k8s_ado_envs-1)
    * Part 2: [Continuous Delivery to AKS With Azure DevOps Environments - Part 1](https://kristhecodingunicorn.com/post/k8s_ado_envs-2)

2. Script for migration of Kubernetes resources to a new Azure DevOps Environment: https://github.com/guidemetothemoon/div-dev-resources/tree/main/scripts/kubernetes/ado-environments

3. Microsoft Docs - Azure DevOps Environments: [Deploy apps to environments](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/environments?view=azure-devops)

4. AKS HTTP Application Routing add-on: [HTTP application routing](https://docs.microsoft.com/en-us/azure/aks/http-application-routing)

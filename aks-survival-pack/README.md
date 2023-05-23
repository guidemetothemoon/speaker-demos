# Introduction

This repo contains resources used for demos in my tech session **"AKS Survival Pack: what to consider before going all-in with Azure Kubernetes Service"**.

# Useful resources

1. AKS Checklist which contains a lot of best practices for adopting Azure Kubernetes Service: [The Azure Kubernetes Service Checklist](https://www.the-aks-checklist.com/)

2. Baseline architecture for AKS provides recommended baseline ingrastructure architecture to deploy AKS clusters according to architectural best practices: [Baseline architecture for an Azure Kubernetes Service (AKS) cluster](https://learn.microsoft.com/en-us/azure/architecture/reference-architectures/containers/aks/baseline-aks)

3. Mission-critical baseline architecture on Azure- guidance for designing a mission critical workload on Azure: [AKS Mission-Critical](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/containers/aks-mission-critical/mission-critical-intro)

4. AKS Landing Zone Accelerator provides architectural approach and reference implementation for scalable AKS clusters: [AKS landing zone accelerator](https://learn.microsoft.com/en-us/azure/cloud-adoption-framework/scenarios/app-platform/aks/landing-zone-accelerator)

5. Azure security baseline for Azure Kubernetes Service: [AKS Security Baseline](https://docs.microsoft.com/en-us/security/benchmark/azure/baselines/aks-security-baseline)

6. Azure Policy for AKS: [Understand Azure Policy for Kubernetes clusters](https://learn.microsoft.com/en-us/azure/governance/policy/concepts/policy-for-kubernetes)

7. AKS Day 2 Operations best practices: [Azure Kubernetes Services (AKS) day-2 operations guide](https://learn.microsoft.com/en-us/azure/architecture/operator-guides/aks/day-2-operations-guide)

8. BCP and DA best practices for AKS: [Best practices for business continuity and disaster recovery in Azure Kubernetes Service (AKS)](https://learn.microsoft.com/en-us/azure/aks/operator-best-practices-multi-region)

9. Azure Resiliency Whitepaper: [Azure Resiliency – Business Continuity and Disaster Recovery](https://azure.microsoft.com/mediahandler/files/resourcefiles/resilience-in-azure-whitepaper/Resiliency-whitepaper.pdf)

10. MS Learn module for cost optimization recommendations for AKS: [Optimize compute costs on Azure Kubernetes Service (AKS)](https://docs.microsoft.com/en-us/training/modules/aks-optimize-compute-costs/)

11. Support policies for AKS article provides details about technical support policies and limitations for Azure Kubernetes Service (AKS), as well as who is responsible for which areas of AKS. [Support policies for Azure Kubernetes Service](https://docs.microsoft.com/en-us/azure/aks/support-policies)

12. Kubernetes version support policy for AKS: [Supported Kubernetes versions in Azure Kubernetes Service (AKS)](https://learn.microsoft.com/en-us/azure/aks/supported-kubernetes-versions?tabs=azure-cli)

13. Shadowserver report on discovered open Kubernetes API Servers. [Over 380 000 open Kubernetes API servers](https://www.shadowserver.org/news/over-380-000-open-kubernetes-api-servers)

14. Summary from Cyble Research Labs on threat hunting exercise findings in terms of publicly exposed Kubernetes clusters: [Organizations at risk of data breaches via misconfigured Kubernetes](https://blog.cyble.com/2022/06/27/exposed-kubernetes-clusters/)

15. Report from CNCF on how organizations are managing Kubernetes and cloud costs with FinOps or Cloud Financial Management: [FinOps for Kubernetes: Insufficient – or nonexistent – Kubernetes cost monitoring is causing overspend ](https://www.cncf.io/blog/2021/06/29/finops-for-kubernetes-insufficient-or-nonexistent-kubernetes-cost-monitoring-is-causing-overspend/)

16. Articles about faulty systemd update for Ubuntu OS which caused massive outage of AKS clusters and other Azure services: 
    * [Microsoft Azure outage continues for some services relying on Ubuntu 'Bionic' release](https://www.zdnet.com/article/microsoft-azure-outage-continues-for-some-services-relying-on-ubuntu-bionic-release/)
    * [Ubuntu Linux and Azure DNS Problem Gives Azure Fits](https://thenewstack.io/ubuntu-linux-and-azure-dns-problem-gives-azure-fits/)

17. Blog post on Azure Developer Community Blog about how you can harden ASP.NET container image to run as non-root on Kubernetes: [Hardening an ASP.NET container running on Kubernetes](https://techcommunity.microsoft.com/t5/azure-developer-community-blog/hardening-an-asp-net-container-running-on-kubernetes/ba-p/2542224)

18. .NET Blog on .NET 6 being included in Ubuntu 22.04 and preview release of .NET with Chiseled Ubuntu Containers which is ultra-small, non-package-manager, non-shell, non-root image, similar to a distroless image: [.NET 6 is now in Ubuntu 22.04](https://devblogs.microsoft.com/dotnet/dotnet-6-is-now-in-ubuntu-2204/)

19. KubeInvaders - Gamified chaos engineering tool for Kubernetes: [KubeInvaders](https://github.com/lucky-sideburn/KubeInvaders)

20. Kubernetes Goat - Intentionally vulnerable Kubernetes cluster: [Kubernetes Goat](https://madhuakula.com/kubernetes-goat)  

21. Success story from VCA, one of the largest pet healthcare companies in the United States, about migrating to Azure and AKS: [Pet care leader turns monolithic app into a global distributed solution on Azure](https://customers.microsoft.com/de-DE/story/815549-pet-care-leader-turns-monolith-app-into-a-global-distributed-solution-on-azure)

22. Draft - an open source tool to generate Kubernetes-related deployment files like Dockerfile and Helm chart: [Draft for Azure Kubernetes Service (AKS)](https://learn.microsoft.com/en-us/azure/aks/draft)

23. Bridge to Kubernetes - an iterative development tool, that is available for Visual Studio and Visual Studio Code (VS Code), for authoring microservice applications that target Kubernetes: [How Bridge to Kubernetes works](https://learn.microsoft.com/en-us/visualstudio/bridge/overview-bridge-to-kubernetes)

24. Shadowserver's daily dashboard that represents scan results for exposed Kubernetes API servers: [Latest Kubernetes API scan results on the Shadowserver Dashboard](https://dashboard.shadowserver.org/statistics/combined/time-series/?date_range=7&source=population&source=population6&source=scan&source=scan6&tag=kubernetes&group_by=geo&style=stacked)
# Introduction

This repo contains resources used for demos in my tech session **"Managed Kubernetes Service: Day Zero Survival Pack"**.

# Useful resources

1. Security guideline for Kubernetes from Center for Internet Security: [CIS Kubernetes Benchmark](https://www.cisecurity.org/benchmark/kubernetes)

2. Kubernetes Hardening Guide from National Security Agency and Cybersecurity and Infrastructure Security Agency: [Kubernetes Hardening Guide](https://media.defense.gov/2022/Aug/29/2003066362/-1/-1/0/CTR_KUBERNETES_HARDENING_GUIDANCE_1.2_20220829.PDF)

3. OWASP Top 10 for securing docker-based container environment: [OWASP Docker Top 10](https://owasp.org/www-project-docker-top-10/)

4. OWASP Top 10 for securing Kubernetes ecosystem: [OWASP Kubernetes Top Ten](https://owasp.org/www-project-kubernetes-top-ten/)

5. MITRE ATT&CK® Matrix for Enterprise to secure container technologies: [Containers Matrix](https://attack.mitre.org/matrices/enterprise/containers/)

6. Application Container Security Guide from NIST that explains the potential security concerns associated with the use of containers and provides recommendations for addressing these concerns: [Application Container Security Guide](https://csrc.nist.gov/publications/detail/sp/800-190/final)

7. Security best practices for Managed Kubernetes Service from some of the public cloud providers:
    * [Azure security baseline for Azure Kubernetes Service](https://learn.microsoft.com/en-us/security/benchmark/azure/baselines/aks-security-baseline)
    * [GKE-Harden your cluster's security](https://cloud.google.com/kubernetes-engine/docs/how-to/hardening-your-cluster)
    * [Amazon EKS Best Practices Guide for Security](https://aws.github.io/aws-eks-best-practices/security/docs/)

8. Managed Kubernetes Service baseline architecture from some of the public cloud providers:
    * [Azure security baseline for Azure Kubernetes Service](https://learn.microsoft.com/en-us/azure/architecture/reference-architectures/containers/aks/baseline-aks) and [AKS baseline for multiregion clusters](https://learn.microsoft.com/en-us/azure/architecture/reference-architectures/containers/aks-multi-region/aks-multi-cluster)
    * [GKE-Standard cluster architecture](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture)
    * [Amazon EKS High-level architecture](https://docs.aws.amazon.com/prescriptive-guidance/latest/containers-provision-eks-clusters-terraform/architecture.html)

9. Resilience and disaster recovery recommendations for Managed Kubernetes Service from some of the public cloud providers:
    * [Best practices for business continuity and disaster recovery in Azure Kubernetes Service (AKS)](https://learn.microsoft.com/en-us/azure/aks/operator-best-practices-multi-region) and [Azure Resiliency – Business Continuity and Disaster Recovery](https://azure.microsoft.com/mediahandler/files/resourcefiles/resilience-in-azure-whitepaper/Resiliency-whitepaper.pdf)
    * [GKE-Disaster recovery planning guide](https://cloud.google.com/architecture/dr-scenarios-planning-guide)
    * [Disaster Recovery (DR) Architecture on AWS-Article Series](https://aws.amazon.com/blogs/architecture/disaster-recovery-dr-architecture-on-aws-part-i-strategies-for-recovery-in-the-cloud)

10. Success stories with adopting Kubernetes that were mentioned during the session:
    * [Forza Horizon 5 crosses the finish line fueled by Azure Kubernetes Service (AKS)](https://customers.microsoft.com/en-us/story/1498781140435260527-forza-horizon-5-crosses-finish-line-fueled-by-azure-kubernetes-service)
    * [News UK Keeps New Content and Capabilities Coming Fast with Amazon EKS and New Relic](https://newrelic.com/blog/how-to-relic/news-uk-content-capabilities-amazon-eks-new-relic)

11. As part of another session I have compiled a list of useful resources to learn about Chaos Engineering: [Chaos Engineering - Learning Resources](https://github.com/guidemetothemoon/Festive-Tech-Calendar-2022/blob/main/learning-resources.md)

12. October 2022 report from RedHunt Labs on their findings of publicly exposed Kubernetes clusters and related components: [Thousands of Unsecured Kubernetes Clusters Exposed on the Internet — Wave 9](https://redhuntlabs.com/blog/unsecured-kubernetes-clusters-exposed.html)

13. Shadowserver report on discovered open Kubernetes API Servers. [Over 380 000 open Kubernetes API servers](https://www.shadowserver.org/news/over-380-000-open-kubernetes-api-servers)

14. Summary from Cyble Research Labs on threat hunting exercise findings in terms of publicly exposed Kubernetes clusters: [Organizations at risk of data breaches via misconfigured Kubernetes](https://blog.cyble.com/2022/06/27/exposed-kubernetes-clusters/)

15. Report from CNCF on how organizations are managing Kubernetes and cloud costs with FinOps or Cloud Financial Management: [FinOps for Kubernetes: Insufficient – or nonexistent – Kubernetes cost monitoring is causing overspend ](https://www.cncf.io/blog/2021/06/29/finops-for-kubernetes-insufficient-or-nonexistent-kubernetes-cost-monitoring-is-causing-overspend/)

16. Articles about faulty systemd update for Ubuntu OS which caused massive outage of AKS clusters and other Azure services: 
    * [Microsoft Azure outage continues for some services relying on Ubuntu 'Bionic' release](https://www.zdnet.com/article/microsoft-azure-outage-continues-for-some-services-relying-on-ubuntu-bionic-release/)
    * [Ubuntu Linux and Azure DNS Problem Gives Azure Fits](https://thenewstack.io/ubuntu-linux-and-azure-dns-problem-gives-azure-fits/)

17. Articles about AWS US region outages:
    * [AWS US East 2 Outage Analysis (July 28th, 2022)](https://metrist.io/blog/aws-us-east-2-outage-analysis-july-28th-2022/)
    * [AWS went down hard, yet again - here's what happened](https://www.techradar.com/news/live/aws-is-down-again-heres-all-we-know)
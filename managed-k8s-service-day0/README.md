# Introduction

This repo contains resources used for demos in my tech session **"Managed Kubernetes Service: Day Zero Survival Pack"**.

# Session Q&A

During the session at Pozitive Technologies 2022 virtual conference I have received following question:

**"Is it worth to deploy simply web application(like advanced blog) with database in Kubernetes? How to prevent bugs on database like overwriting data? I suspect simple Semathors or locking in threads can't help us with this."**

**Answer:** 

When it comes to hosting databases in a Kubernetes cluster, it is possible, but it comes with challenges and considerations that you need to think of and evaluate towards your use case. Initially Kubernetes was created primarily for stateless workloads in order to provide orchestration, self-healing, scaling, high availability, etc for the applications. When it comes to databases, it often becomes a central component that your application relies on, and in most cases you would want it to be highly available and stable at all times. Hosting a database in Kubernetes increases the risk of potential disruptions. You will need to take full responsibility for managing, securing and scaling your databases vs. for example using a fully managed database service that cloud providers are offering. 

You will need to look into the type of a database that you're using and how well it supports being deployed to a Kubernetes cluster. It should also support sharding, failover and replication, which is also crucial to what the question mentions regarding overwriting data. In order to avoid overwriting data with multiple replicas of the database you need to implement a replication strategy where a single database instance allows write operations while you have multiple database instances that allow read operations and are continuously synchronized with the master database, i.e. the database that the data is written to.

To sum it up: if you're just starting out with adopting Kubernetes or have a very simple use case like a simple web application, I would recommend to start by hosting database instances externally, i.e. not in a Kubernetes cluster, but by implementing a managed database instance for example, like Azure SQL Managed Instance. Once you get more experience with operating workloads on Kubernetes, especially stateful workloads, and see the need and value of switching to hosting databases in Kubernetes, you can always do that at a later point.

I would also recommend to check out this article which explains very well what are the challenges with running databases on Kubernetes and what considerations you need to take when planning for implementing it: [To run or not to run a database on Kubernetes: What to consider](https://cloud.google.com/blog/products/databases/to-run-or-not-to-run-a-database-on-kubernetes-what-to-consider)

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
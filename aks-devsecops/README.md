# Introduction

This repo contains resources used for demos in my tech session **"DevSecOps for Azure Kubernetes Service"**.

# Useful resources

1. Azure security baseline for Azure Kubernetes Service: [AKS Security Baseline](https://docs.microsoft.com/en-us/security/benchmark/azure/baselines/aks-security-baseline)

2. AKS Checklist contains a large set of best practices for operating and configuring Azure Kubernetes Service: [The Azure Kubernetes Service Checklist](https://www.the-aks-checklist.com/) 

3. Azure Policy for AKS: [Understand Azure Policy for Kubernetes clusters](https://learn.microsoft.com/en-us/azure/governance/policy/concepts/policy-for-kubernetes)

4. Security guideline for Kubernetes from Center for Internet Security: [CIS Kubernetes Benchmark](https://www.cisecurity.org/benchmark/kubernetes)

5. Kubernetes Hardening Guide from National Security Agency and Cybersecurity and Infrastructure Security Agency: [Kubernetes Hardening Guide](https://media.defense.gov/2022/Aug/29/2003066362/-1/-1/0/CTR_KUBERNETES_HARDENING_GUIDANCE_1.2_20220829.PDF)

6. OWASP Top 10 for securing docker-based container environment: [OWASP Docker Top 10](https://owasp.org/www-project-docker-top-10/) and cheat sheet [Docker Security Cheat Sheet](https://cheatsheetseries.owasp.org/cheatsheets/Docker_Security_Cheat_Sheet.html)

7. OWASP Top 10 for securing Kubernetes ecosystem: [OWASP Kubernetes Top Ten](https://owasp.org/www-project-kubernetes-top-ten/) and cheat sheet: [Kubernetes Security Cheat Sheet](https://cheatsheetseries.owasp.org/cheatsheets/Kubernetes_Security_Cheat_Sheet.html)

8. MITRE ATT&CK® Matrix for Enterprise to secure container technologies: [Containers Matrix](https://attack.mitre.org/matrices/enterprise/containers/)

9. Application Container Security Guide from NIST that explains the potential security concerns associated with the use of containers and provides recommendations for addressing these concerns: [Application Container Security Guide](https://csrc.nist.gov/publications/detail/sp/800-190/final)

10. Kubernetes Goat - Intentionally vulnerable Kubernetes cluster: [Kubernetes Goat](https://madhuakula.com/kubernetes-goat)

11. October 2022 report from RedHunt Labs on their findings of publicly exposed Kubernetes clusters and related components: [Thousands of Unsecured Kubernetes Clusters Exposed on the Internet — Wave 9](https://redhuntlabs.com/blog/unsecured-kubernetes-clusters-exposed.html)

12. Shadowserver report on discovered open Kubernetes API Servers. [Over 380 000 open Kubernetes API servers](https://www.shadowserver.org/news/over-380-000-open-kubernetes-api-servers)

13. Summary from Cyble Research Labs on threat hunting exercise findings in terms of publicly exposed Kubernetes clusters: [Organizations at risk of data breaches via misconfigured Kubernetes](https://blog.cyble.com/2022/06/27/exposed-kubernetes-clusters/)

14. GitHub repo from where you can clone and run KubeStalk to scan your Kubernetes clusters for unwanted openings: [redhuntlabs/KubeStalk](https://github.com/redhuntlabs/kubestalk)

15. Kubernetes Pod Security Standards that define three different policies to broadly cover the security spectrum - from highly-permissive to highly-restrictive: [Pod Security Standards](https://kubernetes.io/docs/concepts/security/pod-security-standards/)

16. MITRE CVE registry search filtered for Kubernetes: [MITRE - Kubernetes CVE Records](https://cve.mitre.org/cgi-bin/cvekey.cgi?keyword=kubernetes)

17. Official Kubernetes CVE feed - a community maintained list of official CVEs announced by the Kubernetes Security Response Committee: [Kubernetes - Official CVE Feed](https://kubernetes.io/docs/reference/issues-security/official-cve-feed/)

18. Cloud Native Security model overview for Kubernetes which defines a model of thinking about Kubernetes security in the context of Cloud Native Security: [Overview of Cloud Native Security](https://kubernetes.io/docs/concepts/security/overview/)

**Some security tools that I would recommend checking out:**

- Hadolint for Dockerfile linting: https://github.com/hadolint/hadolint
- helm lint command of the Helm CLI to lint Helm charts: https://helm.sh/docs/helm/helm_lint/
- Trivy by Aquasec to scan IaC, repositories, secrets, clusters and container images: https://github.com/aquasecurity/trivy
- Kubescape, a really great tool which can become a Swiss Army Knife or a single pane of glass to scan all of your clusters for vulnerabilities, for compliance with security standards, in addition to RBAC Visualizer with more functionality to explore: https://github.com/kubescape/kubescape

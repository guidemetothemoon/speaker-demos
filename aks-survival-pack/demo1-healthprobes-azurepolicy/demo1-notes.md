# Demo 1.1 - Deploy faulty application version without health probes and demonstrate downtime

**Application used during demo:**

[cat-encyclopedia](https://github.com/guidemetothemoon/speaker-demos/tree/main/aks-ado-environments)

- Comment out health probes in ```helm/cat-encyclopedia/templates/deployment.yaml``` and update ```Dockerfile``` to use invalid base image (f.ex. other .NET version) to simulate downtime.

**Commands used during demo:**

- Deploy application with Helm chart: ```helm install [release_name] -n [namespace] [helm_chart]```
- Upgrade application with Helm chart: ```helm upgrade [release_name] -n [namespace] [helm_chart]```
- Check history of application deployments with Helm: ```helm history [release_name] -n [namespace]```
- Rollback application deployment to another version with Helm: ```helm rollback [release_name] [revision_number] -n [namespace]```
- Watch Pods in Kubernetes cluster live: ```kubectl get pods -n [namespace] -w```

# Demo 2.2 - Deploy application that violates configured Azure Policies for AKS

**Application used during demo:**

- See deployment template for AKS HelloWorld app in ```aks-helloworld-app``` folder.
- Install Azure Policy add-on in your AKS cluster and enable following policies on a cluster level for ```aks-helloworld``` namespace with "Deny" effect (add ```aks-helloworld``` to namespace inclusions list in Parameters section of each policy):
    * Kubernetes cluster containers CPU and memory resource limits should not exceed the specified limits
    * Ensure cluster containers have readiness or liveness probes configured
- Comment out health probes and resource/request limits in ```aks-hw-1.yaml``` and ```aks-hw-2.yaml``` to simulate uncompliance with defined policies.

Read more about Azure Policy for AKS: [Understand Azure Policy for Kubernetes clusters](https://learn.microsoft.com/en-us/azure/governance/policy/concepts/policy-for-kubernetes)

**Commands used during demo:**

- Deploy application's Kubernetes YAML templates to a cluster: ```kubectl apply -f aks-hw-1.yaml -f aks-hw-2.yaml -f hw-ingress.yaml -n aks-helloworld```
- Get all application Pods: ```kubectl get pods -n aks-helloworld```
- Get the most extensive output in YAML format for currently running application Deployment: ```kubectl get deploy aks-helloworld-one -n aks-helloworld -o yaml```
- Force re-deployment of Kubernetes resources based on provided Kubernetes YAML templates: ```kubectl replace -f aks-hw-1.yaml -f aks-hw-2.yaml --force```
- Watch Pods in Kubernetes cluster live: ```kubectl get pods -n aks-helloworld -w```
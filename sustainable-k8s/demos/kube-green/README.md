1. Create a new cluster in KIND: ```kind create cluster -n azkaban```

2. Install cert-manager as it's a pre-requisite for kube-green: ```kubectl apply -f https://github.com/jetstack/cert-manager/releases/latest/download/cert-manager.yaml```

3. Install kube-green: ```kubectl apply -f https://github.com/kube-green/kube-green/releases/latest/download/kube-green.yaml```

4. Deploy test application instances: 
```
kubectl create ns chaos-nyan-cat
kubectl apply -f ./chaos-nyan-cat-deploy.yaml
```

5. Deploy kube-green configured SleepInfo object to test app namespace: ```kubectl apply -f ./chaos-nyan-cat-sleepinfo.yaml```

6. (Optional) See SleepInfo resource in the cluster in all namespaces: ```kubectl get sleepinfo -A```

Wait for Pods to terminate and start up again according to schedule! :)


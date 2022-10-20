# GitOps Assessment
## _intro_

hi...

this is an assessment that consist of six stages, complete each stage as you see fit, then submit it to a github repo.

## _Prerequisites_

This assessment requires running a k8s cluster (k3d ), you can run the cluster on your personal machine or for a better environment you can use any cloud service (GCP or Azure).

To complete this assessment your machine need to have the following installed :

- docker
- make (CLI tool)
- WSL (in case you are running windows)


## 1 - Environment Preparation

This assessment uses a lightweight k8s cluster - check this URL [https://thechief.io/c/editorial/k3d-vs-k3s-vs-kind-vs-microk8s-vs-minikube/] :
 
- the first part of the asseessment is to install cluster.
- you can use k3d that can simulate a cluster of more than one node on your personal machine. 

## 2 - Cluster Preparation 

- once the cluster is created you can interact with it using `kubectl`.
- then , in order to prepare the cluster you will need to install _helm_ (the k8s package manager). 

Afterwards, you need to install and deploy the following services to your cluster: 

- nginx ingress 
- prometheus 

## 3 - Service Deployment

- create a dockerfile for sample project in Shopping folder [Shopping.API and Shopping.Client] in the root dir.
- create a deployment file for the sample service with the following conditions :
    - set a soft limit and a hard limit on the service resources consumption.
    - deploy the service without root privileges.
    - limlit the deployment capabilities to only the necessary ones.
    - set the filesystem to be read only.
    - disallow privilege escalation.
    - livenessProbe and readinessProbe must be set on the deployment file (you can find the health endpoit by browsing to /Health/Index in both components).
- create a service file for the sample service.
- create an ingress file that exposes the sample service to outside of the cluster.

all the resources mentioned above should exist on the same one namespace [shopping], and the service should be running and accessible. 

## 4 - CICD Pipeline 

- deploy azure (CICD tool) to your cluster using helm.
- create a pipeline in azure-devops that consists of two main stages - any additional stage will be consider - : 
    - stage 1 : build the sample service docker image and pushes it to dockerhub.
    - stage 2 : deploy the sample service to the cluster with a rollout strategy.

## 5 - Argo-cd App

- deploy argocd on your cluster and link it with this repo
- create argo-cd application
- save that application file with your code

## 6 - Bonus

- use management secret tool to change setings on different environments
- create a canary deployment strategy using argo-rollouts with a good precentage

 ✨ Good Luck ✨

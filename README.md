### Lancement du docker redis

1. Télécharger le projet `$ git clone https://github.com/feur25/no-sql-redis`
<img width="219" alt="Capture d’écran 2024-05-10 à 10 18 09" src="https://github.com/feur25/no-sql-redis/assets/39668417/cbeca091-2e74-446c-a064-1ed3c4855737">

2. `docker-compose build`
3. `docker-compose up` ou `docker-compose up -d`

<img width="583" alt="Capture d’écran 2024-05-10 à 10 17 50" src="https://github.com/feur25/no-sql-redis/assets/39668417/11eb0530-5cc1-4438-bf16-777f8d776798">

# Pour se connecter au client Redis dans le cluster :

    docker exec -it docker-redis-cluster-redis1-1 redis-cli -c -h 173.17.0.2 -p 7000

# Pour définir les informations de l'employé avec l'ID 1 :

    SET employe:1 '{"nom": "John Doe", "poste": "Développeur", "age": 30}'

# Pour obtenir les informations de l'employé avec l'ID 1 :

    GET employe:1

<img width="583" alt="Capture d’écran 2024-05-10 à 10 17 25" src="https://github.com/feur25/no-sql-redis/assets/39668417/e1d85fae-8691-4b4a-8a8d-c2f0cf00a86c">

# Utilisation du server Flask (endpoint) :

Lancer le server flask dans le fichier root du projet, vous pourrez le retrouver

    python3 ./app.py

Une fois lancer, personnelement je suis sur mac vous pourrez aller sur le port 127.0.0.1:5000/redis, quoi vous affichera le contenue de votre redis 

<img width="786" alt="Capture d’écran 2024-05-10 à 11 32 25" src="https://github.com/feur25/no-sql-redis/assets/39668417/243385cf-3cb8-4db6-b28d-17e63a65e9b2">


pour incrémenter un nouvelle employee dans notre redis étant sur mac ou linux vous pourrez utiliser cette command :
    
    curl -X POST -H "Content-Type: application/json" -d '{"nom": "Guillaume", "poste": "Footballeur", "age": 25}' http://127.0.0.1:5000/employee

<img width="562" alt="Capture d’écran 2024-05-10 à 11 32 04" src="https://github.com/feur25/no-sql-redis/assets/39668417/43cb803b-5476-408e-8a92-4ed5afba89b0">


# Partie 4: Introspection sur l'Intégration de Redis

Évaluation des Projets Actuels :

Identifier des Projets Existants : J'ai examiné mes projets existants pour identifier ceux où l'intégration de Redis pourrait être bénéfique. Ces projets incluent mon système de gestion des sessions utilisateur, mon site e-commerce pour la gestion des articles, coupler à du firebase avec leurs système de stockage "firestore", mon application de chat en temps réel et ma plateforme de diffusion de contenu.

Évaluer les Avantages Potentiels : Redis peut améliorer la réactivité de mes applications en stockant les sessions utilisateur en mémoire, accélérer les requêtes de base de données pour le chat en temps réel en utilisant des structures de données rapides telles que les listes et les ensembles, et optimiser la livraison de contenu en mettant en cache les données statiques.

Restitution
J'ai préparé une analyse détaillée sur les avantages de l'intégration de Redis dans différents types de projets, détaillant les gains potentiels en performance, en scalabilité et en efficacité opérationnelle. Cette intégration de Redis s'inscrit dans ma stratégie globale visant à améliorer la robustesse et l'expérience utilisateur de mes applications.




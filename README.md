### Lancement du docker redis

# Pour démarrer le cluster (et la WebApi)
    docker compose up

# Pour se connecter au client Redis dans le cluster :
    docker exec -it redis-redis1-1 redis-cli -c

# Pour définir les informations de l'entrée avec l'Id 1 :
    SET entry:1 '{"FirstName": "David", "LastName": "Harutyunyan", "JobTitle": "Engineer", "age": 21}'

# Pour obtenir les informations de l'entrée avec l'Id 1 :
    GET entry:1

# Accès de la WebApp Api Rest (ASP.NET)

L'API démarre avec le cluster Redis via Docker,
Il suffit d'y accéder aux entrées existentes (GET), ou d'y poster des entrées (POST) via [localhost](http://localhost:80/api).


# Partie 4: Introspection sur l'Intégration de Redis

Entre Redis et ReplicaSet, Redis me paraît être la plus simple solution, bien que certains détails m'éludent.
Les invites de commandes et API intégrées pour les différents langages de scriptages font une grande partie du travail et laissent peu de place pour l'erreur humaine.
Je verrais bien Redis employé dans la création d'un Bot de Messagerie et lecteur musical Discord où il pourrait servir de cache de messagerie et de métadonnées musicales.
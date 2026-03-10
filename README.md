# projet1

## Annexe 1 – Comprendre les fichiers et dossiers du projet

Lorsqu’on crée un projet C# console, plusieurs fichiers et dossiers sont générés automatiquement.
Il n’est pas nécessaire de tous les connaître par cœur au début, mais il est utile de comprendre leur rôle.

### `projet1.csproj`

Le fichier `.csproj` est le fichier de configuration du projet.  
Il indique notamment :

- le type de projet ;  
- la version de .NET utilisée ;  
- certaines options de compilation ;  
- les références nécessaires au projet.

On peut le considérer comme la **fiche d’identité technique du projet**.

### `projet1.sln`

Le fichier `.sln` est le fichier de solution.  
Une solution permet d’organiser un ou plusieurs projets dans un même ensemble de travail.  
Même si on ne travaille que sur un seul projet, ce fichier peut être présent.

On peut le considérer comme le **fichier qui organise l’ensemble du travail**.

### `bin`

Le dossier `bin` est créé automatiquement lors de la compilation ou de l’exécution du programme.  
Il contient les fichiers produits par la compilation, par exemple :

- le programme exécutable ;  
- des bibliothèques ;  
- d’autres fichiers nécessaires au lancement.

On peut le considérer comme le **dossier des résultats de la compilation**.

### `obj`

Le dossier `obj` est également créé automatiquement.  
Il contient des fichiers intermédiaires utilisés par .NET pendant la compilation.  
Ce sont des fichiers techniques temporaires, nécessaires à la construction du projet.

On peut le considérer comme le **dossier de travail interne de la compilation**.

### À retenir

Dans un projet C# :

- les fichiers `.cs` contiennent le code écrit par le développeur ;  
- le fichier `.csproj` décrit techniquement le projet ;  
- le fichier `.sln` organise un ou plusieurs projets ;  
- les dossiers `bin` et `obj` sont générés automatiquement par l’outil de compilation.

## TP POO – Gestion de cours et d’étudiants en C#

### Objectifs

Dans ce TP, vous allez travailler sur :
- la création de classes en C#
- l’utilisation de constructeurs
- la différence entre constructeur sans paramètres et constructeur avec paramètres
- la création de plusieurs constructeurs
- l’utilisation d’une liste d’objets (List<T>)
- l’utilisation des accesseurs (get/set)
- l’utilisation d’un attribut static
- la manipulation d’objets et de collections

Les attributs et méthodes des classes sont indiqués dans le diagramme de classes fourni.

### Exercices 1 à 12

Les exercices 1 à 12 ont été implémentés dans le code du projet (`Program.cs`, `Student.cs`, `Course.cs`).

### Exercice 13 – Vérifier les identifiants automatiques

Observer les valeurs des Id générés pour :
- les étudiants
- les cours

**Réponses aux questions :**

1. **Pourquoi chaque objet possède un identifiant différent ?**  
   Chaque objet possède un identifiant différent car l'attribut `nextId` est partagé entre toutes les instances de la classe (grâce au mot-clé `static`). Lors de la création d'un nouvel objet, l'ID est assigné en utilisant la valeur actuelle de `nextId`, puis `nextId` est incrémenté. Ainsi, chaque nouvel objet reçoit un ID unique et séquentiel.

2. **Pourquoi la variable utilisée pour générer les identifiants est-elle static ?**  
   La variable `nextId` est déclarée `static` pour qu'elle soit partagée par toutes les instances de la classe. Sans `static`, chaque instance aurait sa propre copie de `nextId`, ce qui entraînerait des IDs dupliqués ou non séquentiels. En la rendant statique, elle maintient un état global pour la classe entière, assurant l'unicité des IDs.


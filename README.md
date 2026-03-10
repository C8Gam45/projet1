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


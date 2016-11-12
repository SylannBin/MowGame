# Questions

Suivent les problèmes auxquels nous faisons face ou question qui nous empèche d'avancer

### Container pour le troupeau, la pioche, l'étable, la main et le paquet de carte

Faut-il une classe troupeau qui ne contiendra qu'une liste de cartes et aucune méthode ?
De même pour la pioche, la main et l'étable.

Ou alor suffit-il de les ajouter comme propriétés de "joueur", "manche" ou "jeu" ?

### Autre possibilité: Une classe pour chaque ensemble de cartes

Une classe EnsembleCarte dont hérite : pioche, troupeau, main et etable
Méthodes:

* compterMouches()
* ajouterCarte()
* RetirerCarte()
* ajouterPlusieursCartes()
* vider()

Propriétés:

* nombreMaxCarte

### Interface vs classe abstraite

Je lis plusieurs articles en cherchant sur google mais je n'arrive pas à trouver toutes les informations pour décider.

Si l'on utilise une interface, les propriétés ne sont pas héritées et il faut réécrire les méthodes.
Il vaut donc mieux utiliser des classes abstraites ?

Notre exemple:
IA et humains héritent de joueur
Manche et Jeu héritent de statistiques

### Est-ce important d'avoir une propriété de type bool, correspondant au résultat d'une méthode

Par exemple, si j'ai une méthode qui m'indique si toutes les cartes du troupeau sont présentes, est-ce utile d'avoir une propriété booléenne correspondante qui est mise à jour par la méthode ?


Et comment ça se fait que .... ?

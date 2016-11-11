# Questions

Suivent les problèmes auxquels nous faisons face ou question qui nous empèche d'avancer

### Qu'est ce qui doit être une classe ou non ?

Par exemple, dans une manche il y a une pioche qui est générée et un troupeau qui évolue.
On peut compter le nombre de pose/pioche, le nombre de changement de tour, le nombre max de carte dans le troupeau, etc ...
le nombre max de mouche présente dans le troupeau, et les ramassages volontaires ....

Cela confirme le besoin de la classe manche

Mais faut-il une classe troupeau qui ne contiendra qu'une liste de cartes et aucune méthode ? 

### Est-ce important d'avoir une propriété de type bool, correspondant au résultat d'une méthode

Par exemple, si j'ai une méthode qui m'indique si toutes les cartes du troupeau sont présentes, est-ce utile d'avoir une propriété booléenne correspondante qui est mise à jour par la méthode ?

### Container pour le troupeau

* Il peut y avoir au maximum 19 cartes. 17 de 0 à 16, et potentiellement 2 cartes acrobates.
    * Faut-il utiliser une liste de 19 places
    * ou plutot un dictionnaire de 17 places faisant correspondre un numéro de carte à un nombre de présence (de 0 à 2)


### 

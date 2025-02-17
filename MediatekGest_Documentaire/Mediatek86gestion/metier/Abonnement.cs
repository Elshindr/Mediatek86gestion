﻿using System;

namespace Mediatek86.metier
{
    /// <summary>
    /// Classe de gestion des Abonnements d'une revue
    /// Herite de la Classe Commande
    /// </summary>
    public class Abonnement : Commande
    {

        /// <summary>
        /// Constructeur de la classe Abonnement
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        /// <param name="idSuivi"></param>
        /// <param name="label"></param>
        /// <param name="idRevue"></param>
        /// <param name="dateFinAbonnement"></param>

        public Abonnement(string idCommande, DateTime dateCommande, double montant, string idSuivi, string label, string idRevue, DateTime dateFinAbonnement) :
            base(idCommande, dateCommande, montant, idSuivi, label)
        {
            this.IdRevue = idRevue;
            this.DateFinAbonnement = dateFinAbonnement;
        }


        /// <summary>
        /// Getter et Setter de la propriété idRevue autogénérés
        /// </summary>
        public string IdRevue { get; set; }

        /// <summary>
        /// Getter et Setter de la propriété dateFinAbonnement autogénérés
        /// </summary>
        public DateTime DateFinAbonnement { get; set; }
    }
}

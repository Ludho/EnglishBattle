using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishBattle.Data.Services
{
    public class UtilisateurService
    {
        private EnglishBattleEntities context;

        public UtilisateurService(EnglishBattleEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retourne un objet métier
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>objet métier</returns>
        public Joueur GetItem(int id)
        {
            using (context)
            {
                return context.Joueur.Find(id);
            }
        }

        public Joueur GetItem(string email, string password)
        {
            using (context)
            {
                IQueryable<Joueur> utilisateurs = from Joueur in context.Joueur
                                                       where Joueur.email == email
                                                       && Joueur.motDePasse == password
                                                       select Joueur;

                return utilisateurs.FirstOrDefault();
            }
        }

        public List<Joueur> GetList()
        {
            using (context)
            {
                return context.Joueur.ToList();

            }
        }

        public void Insert(Joueur Joueur)
        {
            using (context)
            {
                context.Joueur.Add(Joueur);
                context.SaveChanges();
            }
        }

        public void Update(Joueur Joueur)
        {
            using (context)
            {
                context.Entry(Joueur).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Joueur Joueur)
        {
            using (context)
            {
                context.Entry(Joueur).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}

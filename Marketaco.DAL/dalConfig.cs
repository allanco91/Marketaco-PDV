using Marketaco.DOM.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Marketaco.DAL
{
    public class dalConfig
    {
        #region Gravar dados no Appconfig
        public void addConfig(string key, string num)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, num);
            config.Save();
        }

        public void atuConfig(string key, string num)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = num;
            config.Save();
        }

        public void delConfig(string id)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(id);
            config.Save();
        }

        public string retornaConfig(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[key].Value;
        }
        #endregion

        #region Lista dados do Appconfig
        public List<string> ListaAppConfig(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            List<string> Lista = new List<string>();
            foreach (string k in config.AppSettings.Settings.AllKeys)
            {
                if (k.StartsWith(key))
                {
                    Lista.Add(config.AppSettings.Settings[k].Value);
                }
            }

            return Lista;
        }

        public List<Categoria> listaCategoriaAdd(string key)
        {
            using (DataContext db = new DataContext())
            {
                List<Categoria> LCat = db.Categorias.OrderBy(c => c.Nome).ToList();

                foreach (string t in ListaAppConfig(key))
                {
                    LCat.RemoveAll(c => c.Nome == t);
                }

                return LCat;
            }
        }
        #endregion
    }
}

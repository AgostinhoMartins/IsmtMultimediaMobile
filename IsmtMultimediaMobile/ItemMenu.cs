using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IsmtMultimediaMobile

{
    public class ItemMenu
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }
        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            /* definir o títulos para os items */
            menuLista = new ObservableCollection<MasterPageItem>();
            var pagina1 = new MasterPageItem() { Title = "Home", Icon = "Home32.png", TargetType = typeof(HomePage) };
            var pagina2 = new MasterPageItem() { Title = "Plano de Estudo", Icon = "Home32.png", TargetType = typeof(PlanoEstudo) };
            var pagina3 = new MasterPageItem() { Title = "Eventos", Icon = "Home32.png", TargetType = typeof(Eventos) };
            var pagina4 = new MasterPageItem() { Title = "Avisos", Icon = "Home32.png", TargetType = typeof(Eventos) };
            var pagina5 = new MasterPageItem() { Title = "Propostas de Emprego", Icon = "Home32.png", TargetType = typeof(PropostasEmprego) };

            /* Adicionar os items dentro do menuLista */
            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
            menuLista.Add(pagina3);
            menuLista.Add(pagina4);
            menuLista.Add(pagina5);

        /* devolve a lista de itens*/
        return menuLista;
        }

    }
}

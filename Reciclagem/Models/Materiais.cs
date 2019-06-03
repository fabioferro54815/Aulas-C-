using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Materiais
    {
        public static Dictionary<int, Lixo> Lixos = new Dictionary<int, Lixo>(){
            {1, new GarrafaSkol()},
            {2, new CopoDescartavel()},
            {3, new LataCoca()},
            {4, new FolhaCaderno()},
            {5, new FitaAdesiva()},
            {6, new MacaPodre()},
        };
    }
}
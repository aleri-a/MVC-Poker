using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Models;
namespace MVC_Controllers
{

    public interface IControllers
    {
        void Start(int brPoena);
        void PodeliKarte(int ulog);
        void Kraj();
        bool Igraj(List<Karta> kOtkri);
       int Ulog { get; set; }
        int BrPoena { get; set; }
        IModel Model { get; set; } //treba mi da znam za tabelu koje karte imam u ruci
        List<Karta> Ruka { get; set; } //msm da ce mi trebati kad pravim interfejs
       List<Karta> RukaSve { get; set; }


        string VrstaPobede { get; set; }



    }
        
    
}

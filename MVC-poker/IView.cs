using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Models;
using MVC_Controllers;
namespace MVC_poker
{
  public  interface IView
    {
       IModel Model { get; set; }
       IControllers Controllers { get; set; }

       
       
    }
}

using MovicunCaribe.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovicunCaribe
{
    public partial class CamionesActivos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder script = new StringBuilder();
            if (!IsPostBack)
            {
                var rutas = new List<Ruta>()
                {
                    new Ruta(){
                        Id=1,
                        Nombre="Ruta 1",
                        tramo = new Recorrido(){
                            Id = 1,
                            Tramo =  new List<Parada>()
                            {
                                new Parada()
                                {
                                    Id = 1,
                                    Nombre="Parada A",
                                    Referencia="Plaza la isla",
                                    Coordenadas = new Coordenadas(){ Latitud=1, Longitud=1 },
                                    //Usos = new List<FrecuenciaUso>()
                                    //{
                                    //    new FrecuenciaUso() { Hora="08:00", UsoPromedio=6 },
                                    //    new FrecuenciaUso() { Hora="09:00", UsoPromedio=4 },
                                    //    new FrecuenciaUso() { Hora="10:00", UsoPromedio=7 }
                                    //}
                                }
                            }
                        }
                    }
                };
                script.Append($"CargaRutas({JsonConvert.SerializeObject(rutas)});");
            }

            ScriptManager.RegisterStartupScript(this, typeof(Page),
                Guid.NewGuid().ToString(), script.ToString(), true);
        }
    }
}
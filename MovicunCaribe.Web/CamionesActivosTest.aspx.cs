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
    public partial class CamionesActivosTest : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder script = new StringBuilder();
            if (!IsPostBack)
            {
                var camion = new List<Camion>()
                {
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) },
                    new Camion(){ Coord = new Coordenadas(1,1) }
                };

                var rutas = new List<Ruta>()
                {
                    new Ruta(){
                        Id=1,
                        Nombre="Ruta 1",
                        Tramo = new Recorrido(){
                            Id = 1,
                            Tramo =  new List<Parada>()
                            {
                                new Parada() { Coordenadas = new Coordenadas(21.1759333,-86.8234568) },new Parada() { Coordenadas = new Coordenadas(21.1749929,-86.8253268) },new Parada() { Coordenadas = new Coordenadas(21.1706681,-86.8265843) },new Parada() { Coordenadas = new Coordenadas(21.168124,-86.8265298) },new Parada() { Coordenadas = new Coordenadas(21.165337,-86.826189) },new Parada() { Coordenadas = new Coordenadas(21.161665,-86.8258626) },new Parada() { Coordenadas = new Coordenadas(21.159842,-86.8256536) },new Parada() { Coordenadas = new Coordenadas(21.15892,-86.825598) },new Parada() { Coordenadas = new Coordenadas(21.1576885,-86.8255442) },new Parada() { Coordenadas = new Coordenadas(21.158401,-86.825352) },new Parada() { Coordenadas = new Coordenadas(21.159149,-86.825388) },new Parada() { Coordenadas = new Coordenadas(21.1611985,-86.8255485) },new Parada() { Coordenadas = new Coordenadas(21.1627891,-86.8256302) },new Parada() { Coordenadas = new Coordenadas(21.1663391,-86.8257837) },new Parada() { Coordenadas = new Coordenadas(21.167916,-86.825909) },new Parada() { Coordenadas = new Coordenadas(21.1743328,-86.8260843) },new Parada() { Coordenadas = new Coordenadas(21.1753835,-86.8239275) },new Parada() { Coordenadas = new Coordenadas(21.1770534,-86.8208399) },
                                new Parada() { Coordenadas = new Coordenadas(21.1588771,-86.8065945) },
                                new Parada() { Coordenadas = new Coordenadas(21.1548583,-86.7995376) },
                                new Parada() { Coordenadas = new Coordenadas(21.150752,-86.795294) },
                                new Parada() { Coordenadas = new Coordenadas(21.147041,-86.7920803) },
                                new Parada() { Coordenadas = new Coordenadas(21.144759,-86.790073) },
                                new Parada() { Coordenadas = new Coordenadas(21.1430647,-86.7827709) },
                                new Parada() { Coordenadas = new Coordenadas(21.1423915,-86.7755872) },
                                new Parada() { Coordenadas = new Coordenadas(21.139835,-86.771879) },new Parada() { Coordenadas = new Coordenadas(21.1384814,-86.7698715) },new Parada() { Coordenadas = new Coordenadas(21.1354087,-86.7633131) },
                                new Parada() { Coordenadas = new Coordenadas(21.1347092,-86.7609454) },new Parada() { Coordenadas = new Coordenadas(21.1346325,-86.7560166) },new Parada() { Coordenadas = new Coordenadas(21.134751,-86.7542303) },
                                new Parada() { Coordenadas = new Coordenadas(21.1367044,-86.7496699) },new Parada() { Coordenadas = new Coordenadas(21.1351974,-86.7481993) },new Parada() { Coordenadas = new Coordenadas(21.1339345,-86.7482063) },
                                new Parada() { Coordenadas = new Coordenadas(21.1325154,-86.7486994) },new Parada() { Coordenadas = new Coordenadas(21.129657,-86.750465) },new Parada() { Coordenadas = new Coordenadas(21.1268832,-86.7533268) },
                                new Parada() { Coordenadas = new Coordenadas(21.123027,-86.755265) },new Parada() { Coordenadas = new Coordenadas(21.1206235,-86.7563568) },new Parada() { Coordenadas = new Coordenadas(21.1184724,-86.757413) },
                                new Parada() { Coordenadas = new Coordenadas(21.1150698,-86.7590161) },new Parada() { Coordenadas = new Coordenadas(21.1127887,-86.7613599) },new Parada() { Coordenadas = new Coordenadas(21.1099701,-86.7631061) },
                                new Parada() { Coordenadas = new Coordenadas(21.1034738,-86.7654847) },new Parada() { Coordenadas = new Coordenadas(21.1006223,-86.7670513) },new Parada() { Coordenadas = new Coordenadas(21.0953692,-86.7695436) },
                                new Parada() { Coordenadas = new Coordenadas(21.0929267,-86.7706726) },new Parada() { Coordenadas = new Coordenadas(21.089516,-86.772407) },new Parada() { Coordenadas = new Coordenadas(21.0876691,-86.7733151) },
                                new Parada() { Coordenadas = new Coordenadas(21.08375,-86.7748197) },new Parada() { Coordenadas = new Coordenadas(21.0803004,-86.7761401) },new Parada() { Coordenadas = new Coordenadas(21.0755564,-86.7775772) },
                                new Parada() { Coordenadas = new Coordenadas(21.0724105,-86.7794073) },new Parada() { Coordenadas = new Coordenadas(21.0704645,-86.7806397) },new Parada() { Coordenadas = new Coordenadas(21.0671785,-86.7804347) },
                                new Parada() { Coordenadas = new Coordenadas(21.0655674,-86.7799536) },new Parada() { Coordenadas = new Coordenadas(21.0609945,-86.7799513) },new Parada() { Coordenadas = new Coordenadas(21.058174,-86.781958) },
                                new Parada() { Coordenadas = new Coordenadas(21.0564912,-86.7825092) },new Parada() { Coordenadas = new Coordenadas(21.0515269,-86.7830479) },new Parada() { Coordenadas = new Coordenadas(21.0479885,-86.7834374) },
                                new Parada() { Coordenadas = new Coordenadas(21.0456614,-86.7833361) },new Parada() { Coordenadas = new Coordenadas(21.040949,-86.783069) },new Parada() { Coordenadas = new Coordenadas(21.0449825,-86.7830087) },
                                new Parada() { Coordenadas = new Coordenadas(21.0483154,-86.7831001) },new Parada() { Coordenadas = new Coordenadas(21.0549127,-86.7824862) },new Parada() { Coordenadas = new Coordenadas(21.0590331,-86.7813786) },
                                new Parada() { Coordenadas = new Coordenadas(21.0619903,-86.7793834) },new Parada() { Coordenadas = new Coordenadas(21.065568,-86.7796843) },new Parada() { Coordenadas = new Coordenadas(21.0673941,-86.7801364) },
                                new Parada() { Coordenadas = new Coordenadas(21.0708536,-86.7798549) },new Parada() { Coordenadas = new Coordenadas(21.0751306,-86.7773725) },new Parada() { Coordenadas = new Coordenadas(21.0762309,-86.7771372) },
                                new Parada() { Coordenadas = new Coordenadas(21.077791,-86.776664) },new Parada() { Coordenadas = new Coordenadas(21.0903625,-86.7716939) },new Parada() { Coordenadas = new Coordenadas(21.092946,-86.7703537) },
                                new Parada() { Coordenadas = new Coordenadas(21.0724601,-86.7790211) },new Parada() { Coordenadas = new Coordenadas(21.110159,-86.7627628) },new Parada() { Coordenadas = new Coordenadas(21.1038227,-86.7650224) },new Parada() { Coordenadas = new Coordenadas(21.0809176,-86.7756076) },new Parada() { Coordenadas = new Coordenadas(21.084387,-86.774271) },new Parada() { Coordenadas = new Coordenadas(21.0877725,-86.7729535) },new Parada() { Coordenadas = new Coordenadas(21.0955761,-86.7691799) },new Parada() { Coordenadas = new Coordenadas(21.097999,-86.7681095) },new Parada() { Coordenadas = new Coordenadas(21.100631,-86.766761) },new Parada() { Coordenadas = new Coordenadas(21.101316,-86.7663783) },new Parada() { Coordenadas = new Coordenadas(21.1119234,-86.7617898) },new Parada() { Coordenadas = new Coordenadas(21.1140567,-86.759779) },new Parada() { Coordenadas = new Coordenadas(21.117681,-86.757137) },new Parada() { Coordenadas = new Coordenadas(21.123902,-86.7547917) },new Parada() { Coordenadas = new Coordenadas(21.129076,-86.750652) },new Parada() { Coordenadas = new Coordenadas(21.1318154,-86.7483567) },new Parada() { Coordenadas = new Coordenadas(21.1361136,-86.7472333) },new Parada() { Coordenadas = new Coordenadas(21.1374259,-86.7489682) },new Parada() { Coordenadas = new Coordenadas(21.1381673,-86.7508989) },new Parada() { Coordenadas = new Coordenadas(21.1350958,-86.7538702) },new Parada() { Coordenadas = new Coordenadas(21.1351516,-86.7612065) },new Parada() { Coordenadas = new Coordenadas(21.1390114,-86.7701143) },new Parada() { Coordenadas = new Coordenadas(21.141938,-86.77441) },new Parada() { Coordenadas = new Coordenadas(21.1440095,-86.777777) },new Parada() { Coordenadas = new Coordenadas(21.143423,-86.7830486) },new Parada() { Coordenadas = new Coordenadas(21.1428776,-86.785936) },new Parada() { Coordenadas = new Coordenadas(21.1457272,-86.7906163) },new Parada() { Coordenadas = new Coordenadas(21.1489322,-86.7932049) },new Parada() { Coordenadas = new Coordenadas(21.1501601,-86.7942562) },new Parada() { Coordenadas = new Coordenadas(21.151413,-86.7957625) },new Parada() { Coordenadas = new Coordenadas(21.1546045,-86.7989621) },new Parada() { Coordenadas = new Coordenadas(21.159181,-86.806481)
                            }
                        }
                        }
                    },
                    new Ruta(){
                        Id=1,
                        Nombre="Ruta 2",
                        Tramo = new Recorrido(){
                            Id = 1,
                            Tramo =  new List<Parada>()
                            {
                                new Parada() { Coordenadas = new Coordenadas(21.1548583,-86.7995376) },
                                new Parada() { Coordenadas = new Coordenadas(21.150752,-86.795294) },
                                new Parada() { Coordenadas = new Coordenadas(21.1430647,-86.7827709) },
                                new Parada() { Coordenadas = new Coordenadas(21.1423915,-86.7755872) },
                                new Parada() { Coordenadas = new Coordenadas(21.1347092,-86.7609454) },new Parada() { Coordenadas = new Coordenadas(21.1346325,-86.7560166) },new Parada() { Coordenadas = new Coordenadas(21.134751,-86.7542303) },
                                new Parada() { Coordenadas = new Coordenadas(21.1367044,-86.7496699) },new Parada() { Coordenadas = new Coordenadas(21.1351974,-86.7481993) },new Parada() { Coordenadas = new Coordenadas(21.1339345,-86.7482063) },
                                new Parada() { Coordenadas = new Coordenadas(21.123027,-86.755265) },new Parada() { Coordenadas = new Coordenadas(21.1206235,-86.7563568) },new Parada() { Coordenadas = new Coordenadas(21.1184724,-86.757413) },
                                new Parada() { Coordenadas = new Coordenadas(21.1150698,-86.7590161) },new Parada() { Coordenadas = new Coordenadas(21.1127887,-86.7613599) },new Parada() { Coordenadas = new Coordenadas(21.1099701,-86.7631061) },
                                new Parada() { Coordenadas = new Coordenadas(21.0724105,-86.7794073) },new Parada() { Coordenadas = new Coordenadas(21.0704645,-86.7806397) },new Parada() { Coordenadas = new Coordenadas(21.0671785,-86.7804347) },
                                new Parada() { Coordenadas = new Coordenadas(21.0655674,-86.7799536) },new Parada() { Coordenadas = new Coordenadas(21.0609945,-86.7799513) },new Parada() { Coordenadas = new Coordenadas(21.058174,-86.781958) },
                            }
                        }
                    }
                };
                script.Append($"CargaRutas({JsonConvert.SerializeObject(rutas)});");
                script.Append($"CargaCamion({JsonConvert.SerializeObject(camion)});");
            }

            ScriptManager.RegisterStartupScript(this, typeof(Page),
                Guid.NewGuid().ToString(), script.ToString(), true);
        }
    }
}
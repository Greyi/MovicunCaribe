<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CamionesActivos.aspx.cs" Inherits="MovicunCaribe.CamionesActivos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-12 col-sm-12">
            <select id="SeleccionRuta" class="form-control"></select>
        </div>
        <div class="col-12 col-sm-12">

        </div>
    </div>

    <script type="text/javascript">
        "use strict";

        let Rutas = [];
        let SeleccionRuta = "#SeleccionRuta";

        function CargaRutas(rutas) {
            Rutas = rutas;
            Rutas.forEach((ruta) => {
                $(SeleccionRuta).append($("<option value='" + ruta.Id + "'>" + ruta.Nombre + "</option>"));
            });

            $(SeleccionRuta).change(() => {
                let idRuta = Number($(SeleccionRuta).val());
                let rutaSelected = Rutas.filter((ruta) => { return ruta.Id === idRuta })[0];
                console.log(rutaSelected);
            });
            $(SeleccionRuta).change();
        }
    </script>

</asp:Content>

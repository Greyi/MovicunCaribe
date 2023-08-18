<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CamionesActivosTest.aspx.cs" Inherits="MovicunCaribe.CamionesActivosTest" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.7.1/dist/leaflet.css" />
    <link rel="stylesheet" type="text/css" href="./style.css" />

    <script src="https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"></script>
    <link rel="stylesheet" href="https://unpkg.com/leaflet-routing-machine@latest/dist/leaflet-routing-machine.css" />
    <script src="https://unpkg.com/leaflet-routing-machine@latest/dist/leaflet-routing-machine.js"></script>
    <%--<script src="script.js"></script>--%>

    <div class="row">
        <div class="col-12 col-sm-12">
            <select id="SeleccionRuta" class="form-control"></select>
        </div>
        <div class="col-12 col-sm-12">
            <div id="map"></div>
        </div>
    </div>

    <script type="text/javascript">
        "use strict";

        let Rutas = [];
        let Camion = [];
        let SeleccionRuta = "#SeleccionRuta";

        var map = L.map('map').setView([21.16872779502777, -86.87326841659517], 6);
        var osm = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
        });
        osm.addTo(map);
        let marker, circle;
        let Points;

        const successCallback = (position) => {

            //Obtenemos las coordenadas
            var lat = position.coords.latitude
            var long = position.coords.longitude
            var accuracy = position.coords.accuracy


            //map.on('click', function (e) {
            //    console.log(e.latlng)
            //})



            var position = "Posicion" + lat.toString() + " " + long.toString();


            marker = L.marker([lat, long])
            marker.bindPopup(position).openPopup();


            var featureGroup = L.featureGroup([marker]).addTo(map)

            map.fitBounds(featureGroup.getBounds());

            //console.log(position); 
            navigator.geolocation.clearWatch(id);
        };

        const errorCallback = (error) => {
            console.log(error);
        }

        const options = {
            enableHighAccuracy: true,
            timeout: 10000,
        }

        Points = L.Routing.control({
            show: false,
            addWaypoints: false,
            draggableWaypoints: false,
            fitSelectedRoutes: false,
            waypoints: []
        }).addTo(map);

        const id = navigator.geolocation.watchPosition(successCallback, errorCallback, options);

        function CargarRuta(ruta) {
            let coords = ruta.Tramo.Tramo.map((parada) => {
                return parada.Coordenadas;
            })
            let points = coords.map((cd) => { return L.latLng(cd.Latitud, cd.Longitud); });
            console.log(Points);
            Points.plan({
                waypoints: points
            });
        }

        function CargaRutas(rutas) {
            Rutas = rutas;
            Rutas.forEach((ruta) => {
                $(SeleccionRuta).append($("<option value='" + ruta.Id + "'>" + ruta.Nombre + "</option>"));
            });

            $(SeleccionRuta).change(() => {
                let idRuta = Number($(SeleccionRuta).val());
                let rutaSelected = Rutas.filter((ruta) => { return ruta.Id === idRuta })[0];
                CargarRuta(rutaSelected);
            });
            $(SeleccionRuta).change();
        }

        function CargaCamion(camion) {
            Camion = camion;
        }

    </script>

</asp:Content>

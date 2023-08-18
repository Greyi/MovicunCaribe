<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CamionesActivos.aspx.cs" Inherits="MovicunCaribe.CamionesActivos" %>

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


        function LoadMap(ruta) {
            $("#map").html("");

            let map = L.map('map').setView([21.16872779502777, -86.87326841659517], 6);
            let osm = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
            });
            osm.addTo(map);

            let successCallback = (position) => {
                let lat = position.coords.latitude
                let long = position.coords.longitude
                let accuracy = position.coords.accuracy

                let positionStr = "Posicion" + lat.toString() + " " + long.toString();
                let marker = L.marker([lat, long])
                marker.bindPopup(positionStr).openPopup();

                let featureGroup = L.featureGroup([marker]).addTo(map)
                map.fitBounds(featureGroup.getBounds());

                navigator.geolocation.clearWatch(id);
            };

            let errorCallback = (error) => {
                console.log(error);
            }

            let options = {
                enableHighAccuracy: true,
                timeout: 10000,
            }

            let id = navigator.geolocation.watchPosition(successCallback, errorCallback, options);

            let coords = ruta.Tramo.Tramo.map((parada) => {
                return parada.Coordenadas;
            })

            L.Routing.control({
                show: false,
                addWaypoints: false,
                draggableWaypoints: false,
                fitSelectedRoutes: false,

                waypoints: coords.map((cd) => {
                    return L.latLng(cd.Latitud, cd.Longitud);
                })
            }).addTo(map);
        }


        function CargaRutas(rutas) {
            Rutas = rutas;
            Rutas.forEach((ruta) => {
                $(SeleccionRuta).append($("<option value='" + ruta.Id + "'>" + ruta.Nombre + "</option>"));
            });

            $(SeleccionRuta).change(() => {
                let idRuta = Number($(SeleccionRuta).val());
                let rutaSelected = Rutas.filter((ruta) => { return ruta.Id === idRuta })[0];
                LoadMap(rutaSelected);
            });
            $(SeleccionRuta).change();
        }

        function CargaCamion(camion) {
            Camion = camion;
        }

    </script>

</asp:Content>

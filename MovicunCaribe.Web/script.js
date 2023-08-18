
var map = L.map('map').setView([21.16872779502777, -86.87326841659517], 6);



// Obtengo el mapa 
var osm = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
});

osm.addTo(map);

let marker, circle;

//Verificamos la navegación y obtenemos posición
const successCallback = (position) => {
    
    //Obtenemos las coordenadas
    var lat = position.coords.latitude
    var long = position.coords.longitude
    var accuracy = position.coords.accuracy


    map.on('click',function(e){
        console.log(e.latlng)
    })
      
    

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

const options ={
    enableHighAccuracy: true,
    timeout: 10000,
}


rout = L.Routing.control({
    show: false,
    addWaypoints: false,
    draggableWaypoints: false,
    fitSelectedRoutes: false,

    waypoints: [

        //Paraderos urbanos
        L.latLng(21.1759333,-86.8234568),L.latLng(21.1749929,-86.8253268),L.latLng(21.1706681,-86.8265843),L.latLng(21.168124,-86.8265298),L.latLng(21.165337,-86.826189),L.latLng(21.161665,-86.8258626),L.latLng(21.159842,-86.8256536),L.latLng(21.15892,-86.825598),L.latLng(21.1576885,-86.8255442),L.latLng(21.158401,-86.825352),L.latLng(21.159149,-86.825388),L.latLng(21.1611985,-86.8255485),L.latLng(21.1627891,-86.8256302),L.latLng(21.1663391,-86.8257837),L.latLng(21.167916,-86.825909),L.latLng(21.1743328,-86.8260843),L.latLng(21.1753835,-86.8239275),L.latLng(21.1770534,-86.8208399), 
        L.latLng(21.1588771,-86.8065945),
        L.latLng(21.1548583,-86.7995376),
        L.latLng(21.150752,-86.795294),
        L.latLng(21.147041,-86.7920803),
        L.latLng(21.144759,-86.790073),
        L.latLng(21.1430647,-86.7827709),
        L.latLng(21.1423915,-86.7755872),
        L.latLng(21.139835,-86.771879),L.latLng(21.1384814,-86.7698715),L.latLng(21.1354087,-86.7633131),L.latLng(21.1347092,-86.7609454),L.latLng(21.1346325,-86.7560166),L.latLng(21.134751,-86.7542303),L.latLng(21.1367044,-86.7496699),L.latLng(21.1351974,-86.7481993),L.latLng(21.1339345,-86.7482063),L.latLng(21.1325154,-86.7486994),L.latLng(21.129657,-86.750465),L.latLng(21.1268832,-86.7533268),L.latLng(21.123027,-86.755265),L.latLng(21.1206235,-86.7563568),L.latLng(21.1184724,-86.757413),L.latLng(21.1150698,-86.7590161),L.latLng(21.1127887,-86.7613599),L.latLng(21.1099701,-86.7631061),L.latLng(21.1034738,-86.7654847),L.latLng(21.1006223,-86.7670513),L.latLng(21.0953692,-86.7695436),L.latLng(21.0929267,-86.7706726),L.latLng(21.089516,-86.772407),L.latLng(21.0876691,-86.7733151),L.latLng(21.08375,-86.7748197),L.latLng(21.0803004,-86.7761401),L.latLng(21.0755564,-86.7775772),L.latLng(21.0724105,-86.7794073),L.latLng(21.0704645,-86.7806397),L.latLng(21.0671785,-86.7804347),L.latLng(21.0655674,-86.7799536),L.latLng(21.0609945,-86.7799513),L.latLng(21.058174,-86.781958),L.latLng(21.0564912,-86.7825092),L.latLng(21.0515269,-86.7830479),L.latLng(21.0479885,-86.7834374),L.latLng(21.0456614,-86.7833361),L.latLng(21.040949,-86.783069),L.latLng(21.0449825,-86.7830087),L.latLng(21.0483154,-86.7831001),L.latLng(21.0549127,-86.7824862),L.latLng(21.0590331,-86.7813786),L.latLng(21.0619903,-86.7793834),L.latLng(21.065568,-86.7796843),L.latLng(21.0673941,-86.7801364),L.latLng(21.0708536,-86.7798549),L.latLng(21.0751306,-86.7773725),L.latLng(21.0762309,-86.7771372),L.latLng(21.077791,-86.776664),L.latLng(21.0903625,-86.7716939),L.latLng(21.092946,-86.7703537),L.latLng(21.0724601,-86.7790211),L.latLng(21.110159,-86.7627628),L.latLng(21.1038227,-86.7650224),L.latLng(21.0809176,-86.7756076),L.latLng(21.084387,-86.774271),L.latLng(21.0877725,-86.7729535),L.latLng(21.0955761,-86.7691799),L.latLng(21.097999,-86.7681095),L.latLng(21.100631,-86.766761),L.latLng(21.101316,-86.7663783),L.latLng(21.1119234,-86.7617898),L.latLng(21.1140567,-86.759779),L.latLng(21.117681,-86.757137),L.latLng(21.123902,-86.7547917),L.latLng(21.129076,-86.750652),L.latLng(21.1318154,-86.7483567),L.latLng(21.1361136,-86.7472333),L.latLng(21.1374259,-86.7489682),L.latLng(21.1381673,-86.7508989),L.latLng(21.1350958,-86.7538702),L.latLng(21.1351516,-86.7612065),L.latLng(21.1390114,-86.7701143),L.latLng(21.141938,-86.77441),L.latLng(21.1440095,-86.777777),L.latLng(21.143423,-86.7830486),L.latLng(21.1428776,-86.785936),L.latLng(21.1457272,-86.7906163),L.latLng(21.1489322,-86.7932049),L.latLng(21.1501601,-86.7942562),L.latLng(21.151413,-86.7957625),L.latLng(21.1546045,-86.7989621),L.latLng(21.159181,-86.806481) 

        //Paraderos zona hotelera

    ]
  }).addTo(map);

const id = navigator.geolocation.watchPosition(successCallback,errorCallback, options);




let latitude;
let longitude;
let geolocalizacao  ;
if ("geolocation" in navigator) {
  
    navigator.geolocation.getCurrentPosition(position=> {
        latitude=position.coords.latitude
        longitude = position.coords.longitude

       


    });
} else {
    console.log("geolocation not available")
}

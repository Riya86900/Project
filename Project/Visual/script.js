const url='http://localhost:61107/api/Customer';

document.getElementById('Button1').addEventListener('click',getData);

function getData(){

    var requestOptions = {

        method: 'GET',

        redirect: 'follow'

      };

     

      fetch("http://localhost:61107/api/Customer", requestOptions)

        .then(response => response.text())

        .then(result => showData(result))

        .catch(error => console.log('error', error));}

function showData(data) {

    document.getElementById('Division').innerHTML = data;

//   _displayCount(data.length);

}

document.getElementById('Button2').addEventListener('click',getSingle);

 function getSingle(){

     var id=document.getElementById("Input").value;

     var url="http://localhost:61107/api/Customer/"+id;

    fetch(url)

    .then(response => response.text())

    .then(result => showRecord(result))

    .catch(error => console.log('error', error));}

function showRecord(data) {

document.getElementById('Division').innerHTML = data;

//let CustomerName = document.getElementById("Button3");

function sendJSON(){

    let FirstName = document.getElementById("customername");
    
    let LastName= document.getElementById("lastname");
    
    let CustomerAddress = document.getElementById("address");

    let MobileNumber= document.getElementById("Number");

    let CreatedBy= document.getElementById("createdby");

    let CreatedAt= document.getElementById("createdat");

    let UpdatedBy= document.getElementById("updatedby");

    let UpdatedAt= document.getElementById("updatedat");
    
    // Creating a XHR object
    
    let xhr = new XMLHttpRequest();
    
    let url = "http://localhost:61107/api/Customer";
    
    // open a connection
    
    xhr.open("POST", url, true);
    
    // Set the request header i.e. which type of content you are sending
    
    xhr.setRequestHeader("Content-Type", "application/json");
    
    // Create a state change callback
    
    xhr.onreadystatechange = function () {
    
    if (xhr.readyState === 4 && xhr.status === 200) {
    
    // Print received data from server
    
    result.innerHTML = this.responseText;
    
    }
    
    };
    
    // Converting JSON data to string
    
    var data = JSON.stringify({ "firstName": FirstName.value , "lastName":LastName.value, "customerAddress":CustomerAddress.value,"mobileNumber":MobileNumber.value,"createdBy": CreatedBy.value ,"createdAt": CreatedAt.value ,"updatedBy": UpdatedBy.value ,"updatedAt": UpdatedAt.value});
    
    // Sending data with the request
    
    xhr.send(data);

    function search() {

        var id=document.getElementById("like").value;
    
        var url="http://localhost:61107/api/Customer/Customer/"+id;
    
        fetch(url)
    
        .then((res) => res.text())
    
        .then(ans => showData(ans))  
    
        }
    
      function showData(data)
    
      {
    
          document.getElementById('Division').innerHTML=data;
    
      }
    }
}
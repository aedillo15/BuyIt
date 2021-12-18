$(document).ready(function(){ 

    //Switch Page from login to signup
    $("#signup-submit").on('click',function(){
        $.mobile.changePage("#signupPage",{ transition: "slideup", changeHash: false });
        });


         function showProducts(){
            fetch('http://localhost:5000/BuyIt/users/products', {
                method: "GET",
                headers: {
                    "content-type": "application/json",
                    'Accept': 'application/json'
                }
            })
                .then(response => response.json())
                .then(data => populateList(data));
        }

        function populateList(items) {
            items.$values.forEach(item => addItem(item));
            //console.log(items.$values[0])           
        }

        function addItem(item) {
    const li = document.createElement('li');
    const addButton = document.createElement('button');
    addButton.innerText = 'Add';
    addButton.id = item.id;
    li.innerHTML = item.name+" "+item.price;
    li.appendChild(addButton);

    document.getElementById("myUL").appendChild(li);
    }

    $( "#signup" ).submit(function( event ) {

        fetch('http://localhost:5000/buyit/users/register', {
            method: "POST",
            headers: {
                "content-type": "application/json"
            },
            body: JSON.stringify({
                UserName: $("#username").val(),
                Email: $("#email").val(),
                Password: $("#password").val()
            })

        })
            .then(response => response.json())
    });
 
    $( "#login").submit(function( event ) {

        fetch('http://localhost:5000/buyit/users/login', {
            method: "POST",
            headers: {
                "content-type": "application/json",
                'Accept': 'application/json'
            },
            body: JSON.stringify({
                Email: $("#loginEmail").val(),
                Password: $("#loginPassword").val()
            })

        })
            .then(response => response.json())
            .then(data => {     
               showProducts();
                $.mobile.changePage("#productsPage",{ transition: "slideup", changeHash: false });});
            });

 });


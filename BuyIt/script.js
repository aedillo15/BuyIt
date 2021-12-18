$(document).ready(function(){ 

    //Switch Page from login to signup
    $("#signup-submit").on('click',function(){
        $.mobile.changePage("#signupPage",{ transition: "slideup", changeHash: false });
        });


        //Not Perfect Yet
        $("#show").on('click',function(){

            fetch('http://localhost:5000/BuyIt/users/products', {
                method: "GET",
                headers: {
                    "content-type": "application/json",
                    'Accept': 'application/json'
                }
            })
                .then(response => response.json())
                .then(data => populateList(data));
        });

        function populateList(items) {
         items.forEach();
           
        }

        function addItem(item) {
console.log(item.name);
console.log(item.price);
    const li = document.createElement('li');
    li.innerHTML = item.name+item.price;
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
                $.mobile.changePage("#productsPage",{ transition: "slideup", changeHash: false });            });
    });

 });


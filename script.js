$(document).ready(function(){ 

    //Switch Page from login to signup
    $("#signUpPageButton").on('click',function(){
        $.mobile.changePage("#signupPage",{ transition: "slideup", changeHash: false });
        });

    $( "#signup" ).submit(function( event ) {
       
      

        fetch('http://localhost:5000/api/Register', {
            method: "POST",
            headers: {
                "content-type": "application/json"
            },
            body: JSON.stringify({
                name: $("#name").val(),
                email: $("#email").val(),
                password: $("#password").val()
            })

        })
            .then(response => response.json())
           // .then(data => registerUser(data));


    });




 //   function registerUser(item) {

  //      console.log(item);

  //  }
 
 });
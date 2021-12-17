
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
//Event Listener for on Click of Login Button 
document.getElementById('login-submit').addEventListener('click', () => {
    
})

//Event Listener for on Click of Sign Up Button 
document.getElementById('signup-submit').addEventListener('click', () => {
    var obj = {}; // Creating user object
    obj.email = document.getElementById("exampleInputEmail1").value
    obj.password = document.getElementById("exampleInputEmail2").value // Extracting form values
    fetch('http://localhost:5000/api/signup', { // When user signs up POST user and add to a list of Users 
        method: "POST", //
        headers: {
            "content-type": "application/json"
        },
        body: JSON.stringify(obj)
    })
    then(response => response.json())
        .then(data => {
            document.getElementByIdById("exampleInputEmail1").value = "";
            document.getElementByIdById("exampleInputEmail2").value = "";
        });
})

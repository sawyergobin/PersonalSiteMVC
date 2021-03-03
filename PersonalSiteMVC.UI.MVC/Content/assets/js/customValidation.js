
function validateForm(event) {
    let controls = document.getElementsByClassName('form-control');
    console.log(controls);

    //gathering all spans that will display error messages into a collection
    let validationMessages = document.getElementsByClassName('invalid');
    let rxpEmail = new RegExp(/^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/);
    
    if (controls['name'].value.length == 0 || controls['email'].value.length == 0 || controls['subject'].value.length == 0 || controls['message'].value.length == 0 || !rxpEmail.test(controls['email'].value)) {
        //stop form from submitting so we can instead display errors
        event.preventDefault();
        //check individual controls (inputs) and display error messages as needed
        //////////NAME
        if (controls['name'].value.length == 0) {
            validationMessages['errorName'].textContent = "*Name is Required";

        }
        else {
            validationMessages['errorName'].textContent = "";
        }
        ///////////EMAIL
        if (controls['email'].value.length == 0) {
            validationMessages['errorEmail'].textContent = "*Email is Required";

        }
        else {
            validationMessages['errorEmail'].textContent = "";
        }

        //////Checking email against the regular expression.
        if (!rxpEmail.test(controls['email'].value) && controls['email'].value.length > 0) {
            validationMessages['errorEmail'].textContent = "*Please enter a valid email address."
        }
        if (rxpEmail.test(controls['email'].value) && controls['email'].value.length > 0) {
            validationMessages['errorEmail'].textContent = ""
        }

        /////////////SUBJECT
        if (controls['subject'].value.length == 0) {
            validationMessages['errorSubject'].textContent = "*Subject is Required";

        }
        else {
            validationMessages['errorSubject'].textContent = "";
        }
        //////////MESSAGE
        if (controls['message'].value.length == 0) {
            validationMessages['errorMessage'].textContent = "*Message is Required";

        }
        else {
            validationMessages['errorMessage'].textContent = "";
        }


    }//end form vaildation IF STATEMENT
    
}//end form validation


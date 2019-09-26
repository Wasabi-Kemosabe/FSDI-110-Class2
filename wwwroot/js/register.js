function clear() {
    $("#make").val("");
    $("#model").val("");
    $("#year").val("");
    $("#color").val("");
    $("#cylinders").val("");
    $("#horsePower").val("");
    $("#doors").val("");
    $("#seats").val("");
    $("#mileage").val("");
    $("#dailyPrice").val("");
    $("#imageURL").val("");
    $("#description").val("");
}

function save() {
    // Get data from the form
    let txtMake = $("#make").val();
    let txtModel = $("#model").val();
    let txtYear = $("#year").val();
    let txtColor = $("#color").val();
    let txtCylinders = $("#cylinders").val();
    let txtHorsepower = $("#horsePower").val();
    let txtDoors = $("#doors").val();
    let txtSeats = $("#seats").val();
    let txtMileage = $("#mileage").val();
    let txtDailyPrice = $("#dailyPrice").val();
    let txtImageURL = $("#imageURL").val();
    let txtDescription = $("#description").val();

    let errorOccured = false;

    // Perform data validations
    $("#year").removeClass("error");
    if (!txtYear || !Number.isInteger(txtYear * 1)) {
        $("#year").addClass("error");
        errorOccured = true;
    }

    $("#dailyPrice").removeClass("error");
    if (!txtDailyPrice || isNaN(txtDailyPrice)) {
        $("#dailyPrice").addClass("error");
        errorOccured = true;
    }

    if (errorOccured) {
        return; // Finish the function, no code below will be executed
    }

    // Create an object
    const car = {
        'Make': txtMake,
        'Model': txtModel,
        'Year': txtYear,
        'Color': txtColor,
        'Cylinders': txtCylinders,
        'HP': txtHorsepower,
        'Doors': txtDoors,
        'Seats': txtSeats,
        'Mileage': txtMileage,
        'DailyPrice': txtDailyPrice,
        'ImageURL': txtImageURL,
        'Description': txtDescription
    };
    console.log(car);

    // Send the object on a POST request
    $.ajax({
        type: "POST",
        url: "/catalog/savecar",
        contentType: "application/json",
        data: JSON.stringify(car),
        success: function (response) {
            console.log("Response from server", response);
            // Will clear the form ONLY IF the submit was successful
            clear();
            $("#divAlert").removeClass("hide");
        },
        error: function (error) {
            console.error("Error from server", error);
        }
    });
}

function init() {
    // Catch click event
    $("#btnSave").click(save);
}

window.onload = init;
function getCatalogData() {
    // Create a JQuery AJAX request
    $.ajax({
        type: "GET",
        url: "/catalog/getCatalog",
        success: function (response) {
            console.log("Server says", response);
            for (let i = 0; i < response.length; i++) {
                displayCar(response[i]);
            }
        },
        error: function (error) {
            console.error("Error getting catalog", error);
        }
    });
}

function displayCar(car) {
    let container = $("#catContainer");
    let template = `
        <div class="card col-6">
            <div class="row">
                <div class="col-7 car-img d-flex align-items-center">
                    <img class="rounded mx-auto d-block" src="${car.imageURL}">
                </div>
                <div class="col-5">
                    <div class="card-body">
                        <h5 class="card-title">${car.make} ${car.model}</h5>
                        <p class="card-text">${car.description}</p>
                        <span>$${car.dailyPrice}.00</span>
                        <button type="button" class="btn btn-primary">Rent</button>
                    </div>
                </div>
            </div>
        </div>
    `;
    container.append(template);
}

function init() {
    console.log("I'm the catalog page");
    getCatalogData();
}

window.onload = init;
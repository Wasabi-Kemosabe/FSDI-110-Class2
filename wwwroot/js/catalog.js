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
                <div class="col-7">
                    <img class="car-img" src="${car.imageURL}">
                </div>
                <div class="col-5">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                        <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
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
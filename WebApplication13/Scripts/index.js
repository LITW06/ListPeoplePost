$(() => {
    let num = 1;

    $("#add-rows").on('click', function () {
        $("#ppl-rows").append(`<div class="row">
                <div class="col-md-4">
                    <input class="form-control" type="text" name="people[${num}].firstname" placeholder="First Name"/>
                </div>
                <div class="col-md-4">
                    <input class="form-control" type="text" name="people[${num}].lastname" placeholder="Last Name"/>
                </div>
                <div class="col-md-4">
                    <input class="form-control" type="text" name="people[${num}].age" placeholder="Age"/>
                </div>
            </div>`);
        num++;
    });
});

//create an mvc application that displays a list of people. On top of the list
//have a link that takes you to a page that allows the user to enter multiple
//people. When that page loads, there should be one row of textboxes (first name,
//lastname and age) with a button on top that says "Add". When Add is clicked,
//another row of textboxes should appear. Beneath those textboxes, there should
//be a submit button, that when clicked, adds all those people to the database
//and then redirects the user back to the home page.
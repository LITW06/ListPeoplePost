$(() => {
    $("#mybutton").on('click', function () {
        const num = Math.floor(Math.random() * 100);
        $("#numbers").append(`<li>${num}</li>`);
    });
});

//create an mvc application that displays a list of people. On top of the list
//have a link that takes you to a page that allows the user to enter multiple
//people. When that page loads, there should be one row of textboxes (first name,
//lastname and age) with a button on top that says "Add". When Add is clicked,
//another row of textboxes should appear. Beneath those textboxes, there should
//be a submit button, that when clicked, adds all those people to the database
//and then redirects the user back to the home page.
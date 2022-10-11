// EXAMPLE OF JS ONE LINE COMMENT

/*
    EXAMPLE OF A JS LONG COMMENT

    JAVASCRIPT = a scripting language used by web browsers to add interactivity for users on different web pages. Used as a way to manipulate an active HTML page through the use of different HTML elements, the console, or the DOM (Document Object Model)
*/


/*
    1 = "function" declaration
    2 = function name
    3 = function arguments/parameters that will be passed in during execution of the function
    4 = function body where any logic that should be executed will be included
*/

// 1        2       3
function doSomething() {
    // 4
    const nameInput = document.getElementById("name");

    /* 
        STRING CONCATENATION = using the "+" operator with strings to combine a string with any other data type that follows, constructing one long string

        TEMPLATE LITERALS = uses `` to declare the string, allowing you to insert variables/JS logic encapsulated inside ${} inside of larger string
    */

    alert(`What do you want ${nameInput.value}?!`);
}
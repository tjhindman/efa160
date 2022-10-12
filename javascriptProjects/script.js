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

// ! DATA TYPES and OPERATORS IN JS

/*
    JAVASCRIPT IS A DYNAMICALLY TYPED LANGUAGE NOT STATIC TYPED => meaning the data type of the variable is determined after the variable is assigned a value

    Number = any positive or negative integer OR decimals
    String = any sequence of characters encapsulated inside of double quotes "", single quotes '', or back ticks ``
    Booleans = "true" or "false" any "COMPARISON OPERATORS" that evaluate as "true" or "false"
        *** 0, NaN, null, undefined, "" are also considered FALSE values
*/

let valEx = null;

console.log(valEx)


// ! OPERATORS IN JS

/*
    ARITHMETIC OPERATORS (basic):
    +
    -
    val++ : same as saying val = val + 1
    val-- : saying val = val - 1
    val+= num : saying val = val + num
    val-= num : says val = val - num
*/

let numOne = 21
let numTwo = 69

console.log(`21 + 69 = ${numOne + numTwo}`)
console.log(`21 - 69 = ${numOne - numTwo}`)

numOne++
console.log(`21++ is ${numOne}`)

numOne--
console.log(`22-- is ${numOne}`)

numOne += 5
console.log(`21 += 5 is ${numOne}`)

numOne -= 5
console.log(`26 -= 5 is ${numOne}`)

/*
    ARITHMETIC OPERATORS (advanced):
    * is multiplication
    / is division
    val*= num : same as saying val = val * num
    val/= num : same as saying val = val / num

    https://www.w3schools.com/js/js_operators.asp
    ** is "exponentation" (to the POWER of)
    % is MODULUS (division remainder)
*/

numOne = 10
numTwo = 40

console.log(`10 * 40 = ${numOne * numTwo}`)
console.log(`10 / 40 = ${numOne / numTwo}`)

numOne *= 5
console.log(`10 *= 5 = ${numOne}`)

numTwo /= 5
console.log(`40 /= 5 = ${numTwo}`)

console.log(`50 ** 2 = ${numOne ** 2}`)

console.log(`40 % 8 = ${numTwo % 8}`)


// ! LOGICAL operators and ORDER OF OPERATIONS
/*
    1. ()
    2. ! (opposite of BOOLEAN variable/value it is written before)
    3. || (OR operator for checking if one of two values evaluate as true)
        - only returns FALSE if both comparisons evaluate as false
    4. && (AND operator for checking if BOTH values evaluate as true)
        - only returns TRUE if both comparisons evaluate as TRUE
*/

console.log(`!true is ${!true}`)
console.log(`false || false is ${false || false}`)
console.log(`false && true is ${false && true}`)

// ! COMPARISON operators
/*
    == "ABSTRACT" equality only compares SPECIFIC VALUES for data
    === "STRICT" equality checks for DATA TYPE as well as VALUE

    != "NOT EQUAL TO"
    !== "STRICT" not equal to

    < less than
    > greater than
    <= less than or equal
    >= greater than or equal
*/

console.log(`'10' == 10 : ${'10' == 10}`)
console.log(`'10' === 10 : ${'10' === 10}`)
// abstract come back
console.log(`'10' != 10 : ${'10' != 10}`)
console.log(`'10' !== 10 : ${'10' !== 10}`)
console.log(`50 < 23 : ${50 < 23}`)
console.log(`50 > 23 : ${50 > 23}`)
console.log(`50 <= 23 : ${50 <= 23}`)
console.log(`50 >= 23 : ${50 >= 23}`)
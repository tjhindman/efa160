// ! OBJECTS
// * JAVASCRIPT IS AN OBJECT ORIENTED PROGRAMMING (OOP) LANGUAGE
/*
    Anything in the "Stack" (value types) Immutable (can't be changed), and any thing on the "Heap" (reference types [like objects/arrays]) are mutable (can be changed).
*/

const student = {
    // COMMA SEPARATED key: 'value', PAIRS TO BUILD OUT STRUCTURE OF OBJECT
    name: "Cassandra",
    age: 21,
    status: "stressed",
    gpa: 4.0,
    passing: true,
}

// * changing object property values/ adding new properties in object
// changing properties (DOES allow different data types to be assigned to the property)
student.name = "Jordan"

// add properties
student.grade = "Post grad"

// ! DESTRUCTRING AN OBJECT IN JS
const {name, age, status} = student

console.log(`This is ${name}. They are ${age} years old and are ${status}.`)

// * SQUARE BRACKET NOTATION IN OBJECTS
console.log(`This student is in ${student["grade"]}`)

console.log(student)


// ! ARRAYS
// values accessed through INDEX (starts at 0) of the value in the array
const arrEx = ["Nick", "Othella", 23, true, {name: "TJ", age: 100}]

// using JSON.stringify() to represent full object and properties as a string
console.log(`arrEx[4] : ${JSON.stringify(arrEx[4])}`)
function Person() {
    this.name = "ABC"
    this.age = 38
    this.phone = 12345
}

var person = new Person()
console.log(person)

person.name = "ABCD"
console.log(person)

Object.entries(person).forEach((key, value) => {
    console.log(key, value)
})

Object.values(person).forEach(element => {
    console.log(element)
})

var animal = {
    type: "Animal",
    x1: "X!!",
    display: function() {
        console.log("Inside function", this.type, this.x1)
    }
}

var horse = Object.create(animal);
console.log("Animal", horse);
console.log(horse.type)
horse.display()
horse.type = 'Carnivorous'
horse.x1 = 'H!!!'
console.log(horse)
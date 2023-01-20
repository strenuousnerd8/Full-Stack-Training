namespace nodejs {
    class C {
    c1: string = "CCC";
    c2: number = 200;
    constructor() {
        console.log("Inside C");
    }

    fnc() {
        console.log("Inside fnc, class C");
    }
    }

    class B extends C {
    private b1: string = "ABC";
    protected b2: number = 300;
    public b3: string = "BBB";
    b4: number = 6000;
    constructor() {
        super();

        console.log("Inside B constructor");
    }

    fnb() {
        console.log("Inside fnb, class B", this.b1, this.b2, this.b3, this.b4);
    }
    }

    class A extends B {
    a1: string = "AAA";
    a2: number = 200;

    constructor() {
        super();

        console.log("Inside A's Constructor");
    }

    fna() {
        console.log("Inside fna, class A", this.b2, this.b3, this.b4);
    }
    }

    let a = new A();

    a.fna();

    console.log("Public specified in parent ", a.b3);
    console.log("Public specified in parent ", a.b4);
}

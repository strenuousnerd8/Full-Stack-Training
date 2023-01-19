namespace nodejs {
    class ABC<T1, T2> {
        private a1: T1;
        private a2: T2;

        fn(x1: T1, x2: T2) {
            this.a1 = x1;

            this.a2 = x2;
        }

        display(): void {
            console.log("Inside A generic Class ", this.a1, this.a2);
        }
    }

    let a1 = new ABC<number, string>();

    a1.fn(12, "abcd");
    a1.display();

    let a2 = new ABC<number, number>();

    a2.fn(84, 38);
    a2.display();
}